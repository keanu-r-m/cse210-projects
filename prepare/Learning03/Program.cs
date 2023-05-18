using System;

class Program
{
    static void Main(string[] args)
    {
        //Create fraction using constructors
        Fraction fract = new Fraction();
        Fraction fract1 = new Fraction();
        Fraction fract2 = new Fraction(5);
        Fraction fract3 = new Fraction(3, 4);
        Fraction fract4 = new Fraction(1, 3);

        //Using getters and setters
        fract.SetTop(2);
        fract.SetBottom(3);
        Console.WriteLine(fract.GetTop());
        Console.WriteLine(fract.GetBottom() + "\n");

        // Calling GetFractionString and GetDecimalValue
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue());
        
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());
        
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());
        
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());
    }
}