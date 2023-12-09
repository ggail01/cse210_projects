using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 12, 10), 30, 4.0),
            new Cycling(new DateTime(2023, 12, 18), 30, 6.0),
            new Swimming(new DateTime(2023, 12, 22), 30, 10)
        };

        Console.WriteLine("\n-----  LIST OF ACTIVITIES  -----");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}