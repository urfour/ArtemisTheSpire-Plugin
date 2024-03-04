using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Core.Modules;
using Artemis.Plugins.Games.SlayTheSpire.GameDataModels;
using Artemis.Plugins.Games.SlayTheSpire.GameDataModels.Combat;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels
{
    public class CombatState : DataModel
    {
        public Card[]? DrawPile { get; set; }
        public Card[]? DiscardPile { get; set; }
        public Card[]? ExhaustPile { get; set; }
        public HandDeck Hand { get; set; } = new();
        public Card[]? Limbo { get; set; }
        public Card? CardInPlay { get; set; }
        public Player? Player { get; set; }
        public Monster[]? Monsters { get; set; }
        public int Turn { get; set; }
        public int CardsDiscardedThisTurn { get; set; }
        public int TimesDamaged { get; set; }
        public void Update(GameCombatState gameCombatState)
        {
            DrawPile = gameCombatState.DrawPile;
            DiscardPile = gameCombatState.DiscardPile;
            ExhaustPile = gameCombatState.ExhaustPile;
            if (gameCombatState.Hand != null)
            {
                Hand.Update(gameCombatState.Hand);
            }
            Limbo = gameCombatState.Limbo;
            CardInPlay = gameCombatState.CardInPlay;
            Player = gameCombatState.Player;
            Monsters = gameCombatState.Monsters;
            Turn = gameCombatState.Turn;
            CardsDiscardedThisTurn = gameCombatState.CardsDiscardedThisTurn;
            TimesDamaged = gameCombatState.TimesDamaged;
        }
    }
}
