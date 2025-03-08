using System;class Trip
{
    public string Destination;
    public double DistanceTraveled;
    public double TotalCost;
    public double GallonsConsumed;


    public Trip(string destination, double distance, double cost, double gallons)
    {
        Destination = destination;
        DistanceTraveled = distance;
        TotalCost = cost;
        GallonsConsumed = gallons;
    }


    public double MilesPerGallon()
    {
        return DistanceTraveled / GallonsConsumed;
    }


    public double CostPerMile()
    {
        return TotalCost / DistanceTraveled;
    }


    public void DisplayTrip()
    {
        Console.WriteLine($"Destination: {Destination}, MPG: {MilesPerGallon()}, Cost Per Mile: {CostPerMile()}");
    }
}

class Program
{
    static void Main()
    {
        Trip trip = new Trip("New York", 300, 50, 10);
        trip.DisplayTrip();
    }
}

