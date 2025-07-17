namespace lab_3;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple For Loop 
        for (int index = 1; index <= 10; index++)
        {
            Console.WriteLine(index); 
        }

        // Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        for (int index = 1; index <= 20; index++)
        {
            if (index % 2 == 0)
            {
                Console.WriteLine(index);
            }
        }

        // Problem 3: While Loop Countdown 
        int counter = 5;
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }

        // Problem 4: While Loop – Multiples of 10 from 10 to 1000 
        int multiplier = 10;
        while (multiplier <= 1000)
        {
          Console.WriteLine(multiplier);
          multiplier += 10;
        }

        // Problem 5: Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (var season in seasons)
        {
            Console.WriteLine(season);
        }

        // Problem 6: Days of the Week (1–7)
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number (1–7) to get the day of the week: ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine($"The day entered is {days[dayNumber]}");
        }
        else 
        {
            Console.WriteLine("Please enter a number between 1 and 7");
        }

        // Problem 7: Favorite Books and Authors
        string[] books = { "The Martian Chronicles", "1984", "Brave New World" };
        string[] authors = { "Ray Bradbury", "George Orwell", "Aldous Huxley" };

        for (int index = 0; index < books.Length; index++)
        {
            Console.WriteLine($"{books[index]} by {authors[index]}");
        }

        // Problem 8: Temperature Tracker
        int[] temperatures = { 72, 65, 80, 90, 55 };

        Array.Sort(temperatures);
        foreach (var temperature in temperatures)
        {
            Console.WriteLine(temperature);
        }
        
        Console.WriteLine($"Lowest temperature is {temperatures[0]}F");
        Console.WriteLine($"Highest temperature is {temperatures[temperatures.Length -1]}F");

        // Problem 9: Reverse Countdown
        int[] numbers = { 5, 4, 3, 2, 1 };

        Array.Reverse(numbers);
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.WriteLine(numbers[index]);
        }
    }
}
