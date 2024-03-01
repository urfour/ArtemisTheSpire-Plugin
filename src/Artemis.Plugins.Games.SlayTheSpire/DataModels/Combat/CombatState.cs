using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Plugins.Games.SlayTheSpire.DataModels.Cards;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels.Combat
{
    public class CombatState
    {
        public Card[]? DrawPile { get; set; }
        public Card[]? DiscardPile { get; set; }
        public Card[]? ExhaustPile { get; set; }
        public Card[]? Hand { get; set; }
        public Card[]? Limbo { get; set; }
        public Card? CardInPlay { get; set; }
        public PlayerState Player { get; set; } = new();
        public Monster[]? Monsters { get; set; }
        public int Turn { get; set; }
        public int CardsDiscardedThisTurn { get; set; }
        public int TimesDamaged { get; set; }
    }
}
