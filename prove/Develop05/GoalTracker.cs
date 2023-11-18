using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals;
    private int _score;

    public GoalTracker()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void SaveProgress()
    {
        Console.Write("What is the filename for the goal file? ");
        string saveFilename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(saveFilename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetGoalsProgress());
            }
        }
    }

    public void LoadProgress()
    {
        Console.Write("What is the filename for the goal file? ");
        string loadFilename = Console.ReadLine();

        string[] lines = File.ReadAllLines(loadFilename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(':');

            string type = parts[0].Trim();
            string value = parts[1].Trim();
            string[] values = parts[2].Split(',');

            switch (type)
            {
                case "Points":
                    _score = int.Parse(value);
                    break;
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(values[0], values[1], int.Parse(values[2]));
                    bool completed = bool.Parse(values[3]);
                    simpleGoal.SetCompleted(completed);
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(values[0], values[1], int.Parse(values[2]));
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    int bonusPoints = int.Parse(values[3]);
                    int targetCount = int.Parse(values[4]);
                    int currentCount = int.Parse(values[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(values[0], values[1], int.Parse(values[2]), bonusPoints, targetCount);
                    checklistGoal.SetCurrentCount(currentCount);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }
}
