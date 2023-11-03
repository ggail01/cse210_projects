using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _listItems = new List<string>();

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on positive aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can from the follwing prompt. Type 'done' to finish.");
        string prompt = GetRandomPrompt();
        Console.WriteLine($" ---- {prompt} ----");
        Console.Write("You may begin in: ");
        CountDownTimer(5);
        Console.WriteLine("");
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

     public void GetListFromUser()
    {
        string item;
        do
        {
            Console.Write("> ");
            item = Console.ReadLine();
            if (item.ToLower() != "done")
            {
                _listItems.Add(item);
                _count++;
            }
        } while (item.ToLower() != "done");
    }
}