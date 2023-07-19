using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>() {
            new Running(10, "Running", "02 Jan 2023", 30),
            new Cycling(15, "Cycling", "12 Mar 2023", 40),
            new Swimming(5, "Swimming", "18 Jul 2023", 60)
        };
        
        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}