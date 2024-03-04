using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Core.Modules;

namespace Artemis.Plugins.Games.SlayTheSpire.GameDataModels.Combat
{
    public class GameCombatState : DataModel
    {
        public Card[]? DrawPile { get; set; }
        public Card[]? DiscardPile { get; set; }
        public Card[]? ExhaustPile { get; set; }
        public Card[]? Hand { get; set; }
        public Card[]? Limbo { get; set; }
        public Card? CardInPlay { get; set; }
        public Player? Player { get; set; }
        public Monster[]? Monsters { get; set; }
        public int Turn { get; set; }
        public int CardsDiscardedThisTurn { get; set; }
        public int TimesDamaged { get; set; }
    }
}
