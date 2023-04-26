using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favNumber);
        DisplayResult(userName, squareNumber);
    }
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");   
    }
    static string PromptUserName() {
        Console.Write("please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber() {
        Console.Write("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number) {
        return number * number;
    }
    static void DisplayResult(string name, int squared) {
        Console.WriteLine($"{name}, the square is {squared}");
    }


}