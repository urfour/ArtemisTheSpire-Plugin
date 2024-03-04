using System.Collections.Generic;
using System.Text.Json;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Core.Services;
using Artemis.Plugins.Games.SlayTheSpire.DataModels;
using Artemis.Plugins.Games.SlayTheSpire.GameDataModels;
using Serilog;

namespace Artemis.Plugins.Games.SlayTheSpire;

[PluginFeature(Name = "Slay The Spire")]
public class SlayTheSpireModule : Module<StsDataModel>
{
    private readonly IWebServerService _webServerService;
    private readonly ILogger _logger;
    public SlayTheSpireModule(IWebServerService webServerService, ILogger logger)
    {
        _webServerService = webServerService;
        _logger = logger;
    }
    public override List<IModuleActivationRequirement> ActivationRequirements { get; } 
        = new() { new ProcessActivationRequirement("java") };

    public override void Enable() 
    {
        _webServerService.AddResponsiveJsonEndPoint<InGameState>(this, "SlayTheSpire", rep =>
        {
            DataModel.Update(rep);
            return DataModel;
        });
    }

    public override void Disable()
    {

    }

    public override void Update(double deltaTime)
    {

    }
}