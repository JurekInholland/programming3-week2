using System;

namespace Assignment01
{
    class Book
    {
        public string title;
        public string author;
        public double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine("[Book] '{0}' by {1}, {2:#.00}", title, author, price);
        }
    }
}
