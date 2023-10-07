using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuePrgram = true;
        Journal journal = new Journal();

        while (continuePrgram)
        {
            Console.WriteLine("\nWelcome to the Journal Program!!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (type: 1-5 only): ");

            switch (Console.ReadLine())
            {
                case "1":
                    journal.CreateEntry();
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    journal.SaveJournal();
                    break;

                case "4":
                    journal.LoadJournal();
                    break;

                case "5":
                    continuePrgram = false;
                    break;
                
                default:
                    break;

            }
        }
    }
}