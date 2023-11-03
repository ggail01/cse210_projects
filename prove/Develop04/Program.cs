using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Mindfulness Program!");
        
         while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("   1. Breathing Activity");
            Console.WriteLine("   2. Reflecting Activity");
            Console.WriteLine("   3. Listing Activity");
            Console.WriteLine("   4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                    break;
            }
        }
    }
}