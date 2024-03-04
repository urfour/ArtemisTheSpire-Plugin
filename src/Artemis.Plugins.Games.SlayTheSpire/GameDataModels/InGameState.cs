using Artemis.Core.Modules;
using Artemis.Plugins.Games.SlayTheSpire.DataModels;
using Artemis.Plugins.Games.SlayTheSpire.GameDataModels.Combat;

namespace Artemis.Plugins.Games.SlayTheSpire.GameDataModels
{
    public class InGameState
    {
        public string? ScreenName { get; set; }
        public bool IsScreenUp { get; set; }
        public string? ScreenType { get; set; }
        public string? RoomPhase { get; set; }
        public string? ActionPhase { get; set; }
        public string? RoomType { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Floor { get; set; }
        public int Act { get; set; }
        public string? ActBoss { get; set; }
        public int Gold { get; set; }
        public long Seed { get; set; }
        public string? Class { get; set; }
        public int AscensionLevel { get; set; }
        public GameCombatState? CombatState { get; set; }
        public Relic[]? Relics { get; set; }
        public Card[]? Deck { get; set; }
        public Room[]? Map { get; set; }
        public Potion[]? Potions { get; set; }
        public Keys Keys { get; set; }
        public InGameState()
        {
            Keys = new Keys();
        }
    }
}