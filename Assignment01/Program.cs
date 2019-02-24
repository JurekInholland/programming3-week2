using System;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            BookStore bookStore = new BookStore();

            // Add books
            bookStore.Add(new Book("War and Peace", "Leo Tolstoy", 25.50));
            bookStore.Add(new Book("Metro 2033", "Dmitry Glukhovsky", 12.99));
            bookStore.Add(new Book("Die Blechtrommel", "Günther Grass", 14.90));

            // Add Magazines
            bookStore.Add(new Magazine("Chip", 4.99, new DateTime(2018, 12, 5)));
            bookStore.Add(new Magazine("Autoweek", 6.75, new DateTime(2018, 11, 10)));

            bookStore.PrintCompleteStock();

            Console.ReadKey();
        }
    }
}
