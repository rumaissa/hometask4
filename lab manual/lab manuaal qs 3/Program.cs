using System;


class MealCard

{

    public string StudentName;

    public int Balance;

    public MealCard(string name, int points = 100)

    {

        StudentName = name;

        Balance = points;

    }

    public void AddPoints(int points)

    {
        Balance += points;

    }


    public void BuyFood(int cost)

    {
        if (Balance >= cost)

        {

            Balance -= cost;

            Console.WriteLine($"Purchase successful. Remaining balance: {Balance}");

        }

        else

        {
            Console.WriteLine("Insufficient balance.");

        }

    }

}



class Program

{
    static void Main()

    {
        MealCard card = new MealCard("John");

        card.BuyFood(30);

        card.AddPoints(50);

        card.BuyFood(80);

    }

}

