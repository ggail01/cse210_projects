using System;
using System.Diagnostics.Contracts;

class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>()
    {
        "How are you today:",
        "Describe a recent challenge you faced. What did you learn from it?",
        "Write about three things you're grateful for today.",
        "If you could achieve any goal or dream in the next five years, what would it be?",
        "List the things you want to experience or accomplish in your lifetime.",
        "Dear Future Self..."
    };

    public void CreateEntry()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        Console.WriteLine($"{randomIndex + 1}. {_prompts[randomIndex]}");

        Console.Write("> ");
        string _response = Console.ReadLine();
        Console.Write("What is Today's Date? (e.x. MM/DD/YYYY): ");
        string _date = Console.ReadLine();

        Entry entry = new Entry(_prompts[randomIndex], _response, _date);
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"\nDate: {entry.Date} - Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournal()
    {
        Console.Write("\nEnter a filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}{entry.Prompt}{entry.Response}");
            }
        }
        Console.WriteLine($"The Journal is already saved to {filename}.");
    }

    public void AppendJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename, append: true))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}{entry.Prompt}{entry.Response}");
            }
        }
    }

    public void LoadJournal()
    {
        Console.Write("\nEnter a filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    if (parts.Length == 3)
                    {
                        string _date = parts[0];
                        string _prompt = parts[1];
                        string _response = parts[2];

                        Entry entry = new Entry(_date, _prompt, _response);
                        _entries.Add(entry);
                    }
                }
            }
            Console.WriteLine($"The Journal is loaded from {filename}");
        }
    }
}