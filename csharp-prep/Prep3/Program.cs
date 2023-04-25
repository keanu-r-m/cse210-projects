using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess;
        int counter = 0;

        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            counter++;

            if (guess < magicNumber) {
                Console.WriteLine("Higher");
            } else if (guess > magicNumber) {
                Console.WriteLine("Lower");
            } else {
                break;
            }
        } while (guess != magicNumber);

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"With {counter} guesses");
    }
}