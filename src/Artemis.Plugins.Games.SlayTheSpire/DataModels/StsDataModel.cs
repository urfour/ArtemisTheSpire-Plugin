using Artemis.Core.Modules;
using Artemis.Plugins.Games.SlayTheSpire.GameDataModels;


namespace Artemis.Plugins.Games.SlayTheSpire.DataModels;

public class StsDataModel : DataModel
{
    public bool InGame { get; set; }
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
    public CombatState CombatState { get; set; } = new();
    public Relic[]? Relics { get; set; }
    public Card[]? Deck { get; set; }
    public Room[]? Map { get; set; }
    public PotionSlots Potions { get; set; } = new();
    public Keys Keys { get; set; } = new();
    public StsDataModel() { }
    public void Update(InGameState gameState)
    {
        ScreenName = gameState.ScreenName;
        IsScreenUp = gameState.IsScreenUp;
        ScreenType = gameState.ScreenType;
        RoomPhase = gameState.RoomPhase;
        ActionPhase = gameState.ActionPhase;
        RoomType = gameState.RoomType;
        CurrentHP = gameState.CurrentHP;
        MaxHP = gameState.MaxHP;
        Floor = gameState.Floor;
        Act = gameState.Act;
        ActBoss = gameState.ActBoss;
        Gold = gameState.Gold;
        Seed = gameState.Seed;
        Class = gameState.Class;
        AscensionLevel = gameState.AscensionLevel;
        Relics = gameState.Relics;
        Deck = gameState.Deck;
        Map = gameState.Map;
        Keys = gameState.Keys;
        if (gameState.Potions != null)
        {
            Potions.Update(gameState.Potions);
        }
        if (gameState.CombatState != null)
        {
            CombatState.Update(gameState.CombatState);
        }

    }
}