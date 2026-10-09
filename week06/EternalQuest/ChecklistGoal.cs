using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description} -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}