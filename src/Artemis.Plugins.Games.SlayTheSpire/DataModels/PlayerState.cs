using Artemis.Core.Modules;
using Artemis.Plugins.Games.SlayTheSpire.DataModels.Combat;
using System;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels
{
    public class PlayerState
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Block { get; set; }
        public Power[]? Powers { get; set; }
        public int Energy { get; set; }
        public Orb[]? Orbs { get; set; }

    }
}