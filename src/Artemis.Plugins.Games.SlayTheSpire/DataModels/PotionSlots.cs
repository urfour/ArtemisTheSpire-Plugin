using Artemis.Plugins.Games.SlayTheSpire.GameDataModels;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels
{
    public class PotionSlots
    {
        public Potion? Slot1 { get; set; }
        public Potion? Slot2 { get; set; }
        public Potion? Slot3 { get; set; }
        public Potion? Slot4 { get; set; }
        public Potion? Slot5 { get; set; }
        public void Update(Potion[] potions)
        {
            if (potions.Length > 0)
                Slot1 = potions[0];
            if (potions.Length > 1)
                Slot2 = potions[1];
            if (potions.Length > 2)
                Slot3 = potions[2];
            if (potions.Length > 3)
                Slot4 = potions[3];
            if (potions.Length > 4)
                Slot5 = potions[4];
        }
    }
}