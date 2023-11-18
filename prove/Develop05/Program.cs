using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            ScoreManager.DisplayScore(score);
            Console.WriteLine(" ");
            UserInterface.DisplayMenu();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Goal newGoal = UserInterface.CreateGoal();
                    goals.Add(newGoal);
                    break;

                case 2:
                    UserInterface.DisplayGoals(goals);
                    break;

                case 3:                   
                    goalTracker.SaveProgress();
                    break;

                case 4:
                    goalTracker.LoadProgress();
                    break;

                case 5:
                    UserInterface. ListGoalsByName(goals);
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    Goal accomplishedGoal = goals[goalIndex];
                    UserInterface.RecordEventForGoal(accomplishedGoal);
                    score += accomplishedGoal.GetPoints();

                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}