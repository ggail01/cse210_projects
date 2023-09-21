using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirement #1 & #2
        // Ask the user for the magic number
        // Console.Write("What is the magic number: ");
        // int MagicNumber = int.Parse(Console.ReadLine());

        // Ask the user for a guess
        // Console.Write("What is your guess number: ");
        // int guess = int.Parse(Console.ReadLine());

        // Doesn't have any Loops:
        // if (guess < MagicNumber)
        // {
        //    Console.WriteLine("Guess Higher");
        // }

        // else if (guess > MagicNumber)
        // {
        //    Console.WriteLine("Guess Lower");
        //}

        // else
        // {
        //    Console.WriteLine("You guessed it!");
        // }


        // With Loops:
        // while (guess != MagicNumber)
        // {

        //    if (guess < MagicNumber)
        //    {
        //        Console.WriteLine("Guess Higher");

        //        Console.Write("What is your guess number: ");
        //        guess = int.Parse(Console.ReadLine());
        //    }

        //    else if (guess > MagicNumber)
        //    {
        //        Console.WriteLine("Guess Lower");

        //        Console.Write("What is your guess number: ");
        //        guess = int.Parse(Console.ReadLine());
        //    }
        // }
        // Console.WriteLine("You Guessed it!");

        // Core Requirement #3
        Random RandomGenerator = new Random();
        int MagicNumber = RandomGenerator.Next(1,101);

        int guess = -1;

        Console.Write("What is your guess number: ");
        guess = int.Parse(Console.ReadLine());

        while (guess != MagicNumber)
        {

            if (guess < MagicNumber)
            {
                Console.WriteLine("Guess Higher");

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess > MagicNumber)
            {
                Console.WriteLine("Guess Lower");

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("You Guessed it!");

    }
}