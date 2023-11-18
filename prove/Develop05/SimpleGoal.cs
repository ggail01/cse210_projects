using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _completed = true;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    public override string GetGoalsProgress()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_completed}";
    }
}