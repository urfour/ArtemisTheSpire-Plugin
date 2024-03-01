using System.Numerics;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels.Combat
{
    public class Monster
    {
        public string? Name { get; set; }
        public string? MonsterId { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Block { get; set; }
        public string? Intent { get; set; }
        public int MoveId { get; set; }
        public int MoveBaseDamage { get; set; }
        public int MoveAdjustedDamage { get; set; }
        public int MoveHits { get; set; }
        public int LastMoveId { get; set; }
        public int SecondLastMoveId { get; set; }
        public bool HalfDead { get; set; }
        public bool IsGone { get; set; }
        public Power[]? Powers { get; set; }
    }
}