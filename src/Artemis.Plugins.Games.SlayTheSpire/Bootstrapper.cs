using Artemis.Core;
using Artemis.GameFinder.Prerequisites;
using Artemis.Plugins.Games.SlayTheSpire.Prerequisites;

namespace Artemis.Plugins.Games.SlayTheSpire;

public class Bootstrapper : PluginBootstrapper
{
    private const uint AppID = 646570;
    private const uint ModTheSpireID = 1605060445;
    private const uint BaseModID = 1605833019;
    public override void OnPluginLoaded(Plugin plugin)
    {
        AddPluginPrerequisite(new IsSteamInstalledPrerequisite(plugin));
        AddPluginPrerequisite(new IsSteamGameInstalledPrerequisite(AppID, "Slay The Spire"));
        AddPluginPrerequisite(new IsWorkshopModInstalledPrerequisite(
            AppID,
            ModTheSpireID,
            "ModTheSpire"
            ));
        AddPluginPrerequisite(new IsWorkshopModInstalledPrerequisite(
             AppID,
             BaseModID,
             "BaseMod"
             ));
    }

    public override void OnPluginEnabled(Plugin plugin)
    {
        
    }
    
    public override void OnPluginDisabled(Plugin plugin)
    {
        
    }
}
