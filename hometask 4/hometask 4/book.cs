using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Book
    {
        public string title;
        public string Author;
        public string ISBN;
        public double Price;

        public void DisplayDatail()
        {
            Console.WriteLine("Book Details is Given Below;");
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Book Price: {Price}");
        }
        public void ApplyDiscount(double percentageBook)
        {
            Price -= Price * (percentageBook / 100);
            Console.WriteLine($"Price after Discount: {Price}");
        }

    }
}