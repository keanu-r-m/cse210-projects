using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("Marcus Aurelus", 50, "stoicism", "Lectures", "Lecture about stoicism", "10/08/2023", "8:00", new Address("123 Main Street", "New York", "NY", "United States"));

        Receptions receptions = new Receptions("Dear Guest, We would like to know if you will attend the event", "Celebration", "Reception", "Celebration of cration of an organization", "13/11/2023", "2:00", new Address("456 Park Avenue", "Buenos Aires", "CABA", "Argentina"));

        Outdoor outdoor = new Outdoor("It will be a sunny day", "Forest exploration", "Outdoor", "Exploration of the forest near the lake", "12/01/2024", "10:00", new Address("123 Main Street", "Toronto", "Ontario", "Canada"));

        Console.WriteLine($"{lecture.GenerateStandardDetails()}\n");
        Console.WriteLine($"{lecture.GenerateShortDescription()}\n");
        Console.WriteLine($"{lecture.GenerateFullDetails()}\n\n");

        Console.WriteLine($"{receptions.GenerateStandardDetails()}\n");
        Console.WriteLine($"{receptions.GenerateShortDescription()}\n");
        Console.WriteLine($"{receptions.GenerateFullDetails()}\n\n");

        Console.WriteLine($"{outdoor.GenerateStandardDetails()}\n");
        Console.WriteLine($"{outdoor.GenerateShortDescription()}\n");
        Console.WriteLine($"{outdoor.GenerateFullDetails()}");
    }
}