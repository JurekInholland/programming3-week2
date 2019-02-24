using System;

namespace Assignment02
{
    class PlayingCard
    {
        public string rank;
        public CardSuit suit;

        public PlayingCard(CardSuit suit, string rank)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}", rank, suit);
        }

    }
}
