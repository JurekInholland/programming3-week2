using System;

namespace Assignment01
{
    class Magazine : Book
    {
        public DateTime release;

        public Magazine(string title, double price, DateTime release) : base(title, "None", price)
        {
            this.release = release;
        }

        public override void Print()
        {
            // Use DateTime.DayOfWeek to get the day in written form
            Console.WriteLine("[Magazine] {0} - release day:{1}, {2:#.00}", title, release.DayOfWeek, price);
        }
    }
}
