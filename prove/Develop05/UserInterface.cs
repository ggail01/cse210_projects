using System;

public class UserInterface
{
    public static Goal CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return new SimpleGoal(name, description, points);
            case 2:
                return new EternalGoal(name, description, points);
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                return new ChecklistGoal(name, description, points, targetCount, bonusPoints);
            default:
                throw new ArgumentException("Invalid choice");
        }
    }

    public static void RecordEventForGoal(Goal goal)
    {
        goal.RecordEvent();

        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
        Console.WriteLine($"You now have {goal.GetPoints()} points.");
    }

    public static void ListGoalsByName(List<Goal> goals)
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
    }

    public static void DisplayGoals(List<Goal> goals)
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayStatus();
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Menu options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Select your choice from the menu: ");
    }
}
