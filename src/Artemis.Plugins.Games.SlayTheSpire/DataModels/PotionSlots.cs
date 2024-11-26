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
            if (potions.Length > 0) Slot1 = potions[0]; else Slot1 = null;
            if (potions.Length > 1) Slot2 = potions[1]; else Slot2 = null;
            if (potions.Length > 2) Slot3 = potions[2]; else Slot3 = null;
            if (potions.Length > 3) Slot4 = potions[3]; else Slot4 = null;
            if (potions.Length > 4) Slot5 = potions[4]; else Slot5 = null;
        }
    }
}