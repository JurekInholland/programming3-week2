using System;
using System.Collections.Generic;

namespace Assignment02
{
    class DeckOfCards
    {
        public List<PlayingCard> deckList;

        public DeckOfCards()
        {
            deckList = new List<PlayingCard>();
            InitCards();
            
        }

        private void InitCards()
        {
            // Note: The cast to (Suit[]) is not strictly necessary, but does make the code 0.5 ns faster.
            // Source: https://stackoverflow.com/a/105402


            string[] allRanks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // Iterate over card suits
            foreach (CardSuit suit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach (string rank in allRanks)
                {
                    deckList.Add(new PlayingCard(suit, rank));
                }
            }

        }

        public void Print()
        {
            foreach (PlayingCard card in deckList)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void Shuffle()
        {
            // Fisher-Yates shuffle https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle

            Random rnd = new Random();

            for (int i = deckList.Count - 1; i > 0; --i)
            {
                int k = rnd.Next(i + 1);

                PlayingCard tempCard = deckList[i];

                deckList[i] = deckList[k];
                deckList[k] = tempCard;
            }
        }
    }
}
