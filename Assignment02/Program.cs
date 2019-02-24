using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            deck.Shuffle();

            Console.WriteLine("###Shuffle###");
            deck.Print();

            Console.ReadKey();
        }
    }
}
