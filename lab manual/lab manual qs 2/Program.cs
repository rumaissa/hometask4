using System;

class Fraction

{

    public int Dividend;

    public int Divisor;

    public Fraction(int dividend, int divisor)

    {

        Dividend = dividend;

        Divisor = divisor;

    }

    public void Display()

    {

        Console.WriteLine($"{Dividend}/{Divisor}");

    }

}

class Program

{

    static void Main()

    {

        Fraction fraction = new Fraction(10, 100);

        fraction.Display();

    }

}

