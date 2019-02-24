using System;
using System.Collections.Generic;

namespace Assignment03
{
    class Player
    {
        public string name;

        public List<PlayingCard> cards;

        public Player(string name)
        {
            cards = new List<PlayingCard>();
            this.name = name;
        }

        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard takenCard = cards[0];
            cards.RemoveAt(0);
            return takenCard;
        }
    }
    
}
