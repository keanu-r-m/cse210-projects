using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string grade;

        if (gradePercentage >= 90) {
            grade = "A";
        }
        else if (gradePercentage >= 80) {
            grade = "B";
        }
        else if (gradePercentage >= 70) {
            grade = "C";
        }
        else if (gradePercentage >= 60) {
            grade = "D";
        }
        else {
            grade = "F";
        }

        Console.WriteLine("Your grade is " + grade);
        
        if (gradePercentage >= 70) {
            Console.WriteLine("Congratulation, you passed!");
        }
        else {
            Console.WriteLine("Unfortunately, you didn't pass, you'll do better next time");
        }
    }

}