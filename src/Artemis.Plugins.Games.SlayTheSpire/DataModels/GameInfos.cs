using Artemis.Core.Modules;
using System;
using System.Collections.Generic;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels;

public class GameInfos : DataModel
{
    public GameInfos() {}
    public bool InGame { get; set; }
    public GameState GameState { get; set; } = new();
    [DataModelIgnore]
    public string[]? AvailableCommands { get; set; }
    [DataModelIgnore]
    public bool ReadyForCommand { get; set; }
}