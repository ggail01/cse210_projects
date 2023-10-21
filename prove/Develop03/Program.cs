using System;


public class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptures = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, scriptures);

        Console.WriteLine($"\n{reference.GetRenderedText()} {scriptures}");

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }

            scripture.HideWords(5);
            Console.Clear();
            Console.WriteLine($"{scripture.GetRenderedText()}");
        }
        Console.WriteLine("Program finished! Thank you");
    }
}