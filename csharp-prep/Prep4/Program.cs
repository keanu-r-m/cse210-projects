using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> listNumber = new List<int>();
        int sum = 0;

        while (number != 0) {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) break;
            listNumber.Add(number);
        }
        foreach (int i in listNumber) sum += i;
        double average = (double)sum / listNumber.Count();
        int max = 0;
        foreach (int i in listNumber) {
            if (max < i) max = i;
        }
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }   
}