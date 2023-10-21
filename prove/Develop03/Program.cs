using System;


public class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 2, 17);
        string scriptures = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        Scripture scripture = new Scripture(reference, scriptures);

        Console.WriteLine($"\n{reference.GetRenderedText()} - {scriptures}\n");

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }

            int wordsToHide = 3;
            scripture.HideWords(wordsToHide);
            Console.Clear();
            Console.WriteLine($"{scripture.GetRenderedText()}");
        }
        Console.WriteLine("Program finished! Thank you.");
    }
}