using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements #1 & #3
        Console.Write("What is your grade percentage? ");
        string useranswer = Console.ReadLine();
        int grade = int.Parse(useranswer);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter =  "D";
        }

        else
        {
            letter = "F";
        }
        // Console.WriteLine($"This is your grade: {letter}");


        // Stretch Challenge nos. 1, 2, & 3
        string firstd = useranswer.Substring(0, 1);
        int firstdigit = int.Parse(firstd);

        string lastd = useranswer.Substring(1, 1);
        int lastdigit = int.Parse(lastd);

        // Logic for plus or minus grade
        string ext;

        if ((firstdigit > 5 && firstdigit < 9) && lastdigit >= 7)
        {
            ext = "+";
        }
        else if ((firstdigit > 5 && firstdigit <= 9) && lastdigit < 3)
        {
            ext = "-";
        }
        else
        {
            ext = "";
        }

        Console.WriteLine($"Your grade is: {letter}{ext}");

        // Core Requirement #2
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You Passed.");
        }

        else
        {
            Console.WriteLine("Sorry, you did not Pass. Better luck next time!");
        }
    }
}