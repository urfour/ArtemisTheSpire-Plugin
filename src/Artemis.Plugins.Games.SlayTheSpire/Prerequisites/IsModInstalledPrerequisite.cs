﻿using Artemis.Core;
using Artemis.GameFinder.Utils;
using GameFinder.RegistryUtils;
using GameFinder.StoreHandlers.Steam;
using NexusMods.Paths;
using GameFinder.StoreHandlers.Steam.Models.ValueTypes;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace Artemis.Plugins.Games.SlayTheSpire.Prerequisites;

/// <summary>
///   Checks if a Steam game is installed
/// </summary>
public class IsWorkshopModInstalledPrerequisite : PluginPrerequisite
{
    private readonly SteamHandler _steamHandler;
    private readonly uint _gameId;

    public IsWorkshopModInstalledPrerequisite(uint gameId, uint modId, string? modName = null)
    {
        var modNameOrId = modName ?? modId.ToString();
        InstallActions = new List<PluginPrerequisiteAction>
        {
            new RunInlinePowerShellAction($"Install mod {modNameOrId}", $"start \"steam://url/CommunityFilePage/{modId}\"")
        };
        UninstallActions = new List<PluginPrerequisiteAction>();
        ModId = modId;
        Name = $"Workshop mod \"{modNameOrId}\" installed";
        Description = $"Workshop mod {modNameOrId} must be installed to use this plugin";

        _steamHandler = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? new SteamHandler(FileSystem.Shared, WindowsRegistry.Shared)
            : new SteamHandler(FileSystem.Shared, null);
        _gameId = gameId;
    }

    public override bool IsMet()
    {
        if (!TryGetGamePath(_gameId, out var path))
            return false;
            
        return Directory.Exists(Path.Combine(Directory.GetParent(path)!.Parent!.ToString(), $"workshop/content/{_gameId}/{ModId}"));
    }

    private bool TryGetGamePath(uint id, [NotNullWhen(true)] out string? path)
    {
        var games = _steamHandler.FindAllGames();
        var game = games.Where(x => x.IsT0)
            .Select(r => r.AsT0)
            .FirstOrDefault(g => g?.AppId == AppId.From(id));

        if (game is null)
        {
            path = null;
            return false;
        }

        path = game.Path.GetFullPath();
        return true;
    }

    public uint ModId { get; }
    public override string Name { get; }
    public override string Description { get; }
    public override List<PluginPrerequisiteAction> InstallActions { get; }
    public override List<PluginPrerequisiteAction> UninstallActions { get; }
}