using Artemis.Plugins.Games.SlayTheSpire.GameDataModels;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels
{
    public class HandDeck
    {
        public Card? Card1 { get; set; }
        public Card? Card2 { get; set; }
        public Card? Card3 { get; set; }
        public Card? Card4 { get; set; }
        public Card? Card5 { get; set; }
        public Card? Card6 { get; set; }
        public Card? Card7 { get; set; }
        public Card? Card8 { get; set; }
        public Card? Card9 { get; set; }
        public Card? Card10 { get; set; }
        public int CardCount { get; set; }

        public void Update(Card[] hand)
        {
            if (hand.Length > 0) Card1 = hand[0]; else Card1 = null;
            if (hand.Length > 1) Card2 = hand[1]; else Card2 = null;
            if (hand.Length > 2) Card3 = hand[2]; else Card3 = null;
            if (hand.Length > 3) Card4 = hand[3]; else Card4 = null;
            if (hand.Length > 4) Card5 = hand[4]; else Card5 = null;
            if (hand.Length > 5) Card6 = hand[5]; else Card6 = null;
            if (hand.Length > 6) Card7 = hand[6]; else Card7 = null;
            if (hand.Length > 7) Card8 = hand[7]; else Card8 = null;
            if (hand.Length > 8) Card9 = hand[8]; else Card9 = null;
            if (hand.Length > 9) Card10 = hand[9]; else Card10 = null;
            CardCount = hand.Length;
        }
    }
}