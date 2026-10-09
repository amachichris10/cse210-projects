using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override void RecordEvent()
    {
        // Eternal goals do not have a completion state, so we don't change any state here.
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete.
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}