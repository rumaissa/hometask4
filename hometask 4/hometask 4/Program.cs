using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "maala";
            book1.Author ="namrah ahmed";
            book1.ISBN = "978345678106";
            book1.Price = 4100;

            book1.DisplayDatail();
            book1.ApplyDiscount(10);
        }
    }
}