using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }


    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        _completed = _currentCount == _targetCount;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus(); 
        Console.Write($" --- Currently completed: {_currentCount}/{_targetCount}");
    }

    public override string GetGoalsProgress()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonusPoints},{_targetCount},{_currentCount}";
    }
}
