using System;

class Book


{


    public string ISBN;


    public string Title;


    public double Price;


    public string MajorArea;


    public string SubArea;


    public int Pages;


    public static void InputBooks(Book[] books)


    {


        for (int i = 0; i < books.Length; i++)


        {


            Console.Write("Enter ISBN: ");


            string isbn = Console.ReadLine();


            Console.Write("Enter Title: ");


            string title = Console.ReadLine();


            Console.Write("Enter Price: ");


            double price = double.Parse(Console.ReadLine());


            Console.Write("Enter Major Area: ");


            string major = Console.ReadLine();


            Console.Write("Enter Sub Area: ");


            string sub = Console.ReadLine();


            Console.Write("Enter Pages: ");


            int pages = int.Parse(Console.ReadLine());


            books[i] = new Book { ISBN = isbn, Title = title, Price = price, MajorArea = major, SubArea = sub, Pages = pages };


        }


    }


    public static void PrintBooks(Book[] books)


    {


        foreach (var book in books)


        {


            Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Price: {book.Price}, Major: {book.MajorArea}, Sub: {book.SubArea}, Pages: {book.Pages}");


        }


    }


    public static Book SearchBook(Book[] books, string title)


    {


        foreach (var book in books)


        {


            if (book.Title == title)


                return book;


        }


        return null;


    }


}


class Program


{


    static void Main()


    {


        Book[] books = new Book[2];


        Book.InputBooks(books);


        Book.PrintBooks(books);





        Console.Write("Enter title to search: ");


        string title = Console.ReadLine();


        Book foundBook = Book.SearchBook(books, title);





        if (foundBook != null)


            Console.WriteLine($"Found: {foundBook.Title}, Price: {foundBook.Price}");


        else


            Console.WriteLine("Book not found.");

    }

}

