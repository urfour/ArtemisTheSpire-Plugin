namespace Artemis.Plugins.Games.SlayTheSpire.GameDataModels
{
    public class Card
    {
        public string? Name { get; set; }
        public string? UUID { get; set; }
        public int Misc { get; set; }
        public bool IsPlayable { get; set; }
        public int Cost { get; set; }
        public int Upgrades { get; set; }
        public string? CardId { get; set; }
        public string? Type { get; set; }
        public string? Rarity { get; set; }
        public bool HasTarget { get; set; }
        public bool Exhausts { get; set; }
        public bool Ethereal { get; set; }
    }
}