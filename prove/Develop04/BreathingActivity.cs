using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int cycleDuration = 5;
        int totalDuration = _duration / cycleDuration;

        for (int i = 0; i < totalDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowingSpinner(3); // Pause for 3 seconds
            Console.WriteLine("Now, Breathe out...");
            ShowingSpinner(4); // Pause for 4 seconds
        };
        DisplayEndingMessage();
    }
}