using System;
using System.Collections.Generic;

namespace Assignment01
{
    class BookStore
    {
        public List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void PrintCompleteStock()
        {
            double totalPrice = 0;

            foreach (Book book in books)
            {
                book.Print();
                totalPrice += book.price;
            }
            Console.WriteLine();
            Console.WriteLine("Total sales price: {0}", totalPrice);
        }
    }
}
