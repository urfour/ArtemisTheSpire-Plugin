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
            if (hand.Length > 0)
                Card1 = hand[0];
            if (hand.Length > 1)
                Card2 = hand[1];
            if (hand.Length > 2)
                Card3 = hand[2];
            if (hand.Length > 3)
                Card4 = hand[3];
            if (hand.Length > 4)
                Card5 = hand[4];
            if (hand.Length > 5)
                Card6 = hand[5];
            if (hand.Length > 6)
                Card7 = hand[6];
            if (hand.Length > 7)
                Card8 = hand[7];
            if (hand.Length > 8)
                Card9 = hand[8];
            if (hand.Length > 9)
                Card10 = hand[9];
            CardCount = hand.Length;
        }
    }
}