using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", 240, 4);
        Bicycle bike = new Bicycle("Trek", 45, "Mountain");

        car.DisplayInfo();
        bike.DisplayInfo();

        car.Move();
        bike.Move();
    }
}

class Transport
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Transport(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} moves at a speed of up to {MaxSpeed} km/h.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Max Speed: {MaxSpeed} km/h");
    }
}

class Car : Transport
{
    public int DoorCount { get; set; }

    public Car(string name, int maxSpeed, int doorCount)
        : base(name, maxSpeed)
    {
        DoorCount = doorCount;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} moves on the road at a speed of up to {MaxSpeed} km/h.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Door Count: {DoorCount}");
    }
}

class Bicycle : Transport
{
    public string BikeType { get; set; }

    public Bicycle(string name, int maxSpeed, string bikeType)
        : base(name, maxSpeed)
    {
        BikeType = bikeType;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} moves on the path at a speed of up to {MaxSpeed} km/h.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bike Type: {BikeType}");
    }
}
