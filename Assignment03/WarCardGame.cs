using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;


        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();

            for (int i = 0; i < deck.allPlayingCards.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("adde p1");
                    player1.AddCard(deck.allPlayingCards[i]);
                } else
                {
                    player2.AddCard(deck.allPlayingCards[i]);
                }
            }
        }

        public bool EndOfGame()
        {
            if (player1.cards.Count == 0 || player2.cards.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void NextCard()
        {
            PlayingCard card1 = player1.GetNextCard();
            PlayingCard card2 = player2.GetNextCard();

            Console.ResetColor();
            Console.WriteLine("[{0}] {1} of {2} - [{3}] {4} of {5}", player1.name, card1.rank, card1.suit, player2.name, card2.rank, card2.suit);

            // Create an array containing all card ranks, sorted by ranking (Ace is highest) This is used to compare the actual value.
            string[] ranking = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

            int card1Value = Array.IndexOf(ranking, card1.rank);
            int card2Value = Array.IndexOf(ranking, card2.rank);


            if (card1Value > card2Value)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} got the cards", player1.name);

                player1.AddCard(card2);
                player1.AddCard(card1);
                
            } else if (card1Value == card2Value)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost....");
                Console.WriteLine("cards left: [{0}] {1}x, [{2}] {3}x", player1.name, player1.cards.Count, player2.name, player2.cards.Count);
            } else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} got the cards", player2.name);
                
                player2.AddCard(card1);
                player2.AddCard(card2);

            }

        }
    }
}
