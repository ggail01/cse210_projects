using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
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

     public override string GetGoalsProgress()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}