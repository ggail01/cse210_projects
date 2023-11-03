using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter the duration (in seconds) you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready to begin...");
        ShowingSpinner(5); // Pause for 5 seconds
        Console.WriteLine("");
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! Stay mindful!");
        ShowingSpinner(3); // Pause for 3 seconds
        Console.WriteLine($"\nYou have completed the {_name} in {_duration} seconds.");
        ShowingSpinner(3); // Pause for 3 seconds
        Console.WriteLine("");
        Console.Clear();
    }

    public void ShowingSpinner(int second)
    {
        List<string> spinnerChars = new List<string>();
        spinnerChars.Add("|");
        spinnerChars.Add("/");
        spinnerChars.Add("-");
        spinnerChars.Add("\\");
        spinnerChars.Add("|");
        spinnerChars.Add("/");
        spinnerChars.Add("-");
        spinnerChars.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerChars[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if(i >= spinnerChars.Count)
            {
                i = 0;
            }
        }
    }

    public void CountDownTimer(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}