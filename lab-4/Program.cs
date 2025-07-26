using System;

class Car
{
    public string model;
    public string color;
    public int year;

    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Year: {year}");
    }

    // Problem 1: Add a Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting");
    }

    // Problem 2: Add a Method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles");
    }

    // Problem 3: Add a Method with a Return Value
    public string GetDescription()
    {
        return $"{year} {color} {model}";
    }

    // Problem 4: Add a Method that Updates a Field
    public void Repaint(string newColor)
    {
        this.color = newColor;
        Console.WriteLine($"The car has been repainted to {newColor}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display();

        myCar.Start();
        myCar.Drive(50);

        var description = myCar.GetDescription();
        Console.WriteLine(description);
        
        var newColor = "Red";
        myCar.Repaint(newColor);
        if (myCar.color == newColor)
        {
            Console.WriteLine($"Car color updated to {myCar.color}");
        }
    }
}

