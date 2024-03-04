using Artemis.Core.Modules;
using System;

namespace Artemis.Plugins.Games.SlayTheSpire.GameDataModels.Combat
{
    public class Player
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Block { get; set; }
        public Power[]? Powers { get; set; }
        public int Energy { get; set; }
        public Orb[]? Orbs { get; set; }

    }
}