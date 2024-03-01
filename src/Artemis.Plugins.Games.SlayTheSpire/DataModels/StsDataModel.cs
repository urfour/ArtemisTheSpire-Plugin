using Artemis.Core.Modules;
using System.Collections.Generic;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels;

public class StsDataModel : DataModel
{
    public GameInfos Infos { get; set; }
    public StsDataModel()
    {
        Infos = new GameInfos();
    }
}