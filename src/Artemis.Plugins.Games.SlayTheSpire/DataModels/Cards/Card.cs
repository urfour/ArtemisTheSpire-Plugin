namespace Artemis.Plugins.Games.SlayTheSpire.DataModels.Cards
{
    public class Card
    {
        public bool Exhausts { get; set; }
        public int Cost { get; set; }
        public string? Name { get; set; }
        public string? CardId { get; set; }
        public string? Type { get; set; }
        public bool Ethereal { get; set; }
        public string? UUID { get; set; }
        public int Upgrades { get; set; }
        public string? Rarity { get; set; }
        public bool HasTarget { get; set; }
    }
}