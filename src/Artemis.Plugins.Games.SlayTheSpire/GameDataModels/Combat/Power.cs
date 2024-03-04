using Artemis.Plugins.Games.SlayTheSpire.GameDataModels;

namespace Artemis.Plugins.Games.SlayTheSpire.GameDataModels.Combat
{
    public class Power
    {
        public string? PowerId { get; set; }
        public string? Name { get; set; }
        public int Amount { get; set; }
        public int? Damage { get; set; }
        public Card? Card { get; set; }
        public int Misc { get; set; }
        public bool JustApplied { get; set; }
    }
}