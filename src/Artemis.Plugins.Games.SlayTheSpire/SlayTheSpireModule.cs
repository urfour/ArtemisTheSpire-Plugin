using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Core.Services;
using Artemis.Plugins.Games.SlayTheSpire.DataModels;

namespace Artemis.Plugins.Games.SlayTheSpire;

[PluginFeature(Name = "Slay The Spire")]
public class SlayTheSpireModule : Module<StsDataModel>
{
    private readonly IWebServerService _webServerService;
    public SlayTheSpireModule(IWebServerService webServerService)
    {
        _webServerService = webServerService;
    }
    public override List<IModuleActivationRequirement> ActivationRequirements { get; } 
        = new() { new ProcessActivationRequirement("SlayTheSpire") };

    public override void Enable() 
    {
        _webServerService.AddResponsiveJsonEndPoint<GameInfos>(this, "SlayTheSpire", rep =>
        {
            DataModel.Infos = rep;
            return DataModel.Infos;
        });
    }

    public override void Disable()
    {

    }

    public override void Update(double deltaTime)
    {

    }
}