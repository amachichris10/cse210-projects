using System;

class Running : Exercise
{
    private string _name = "Running";
    private double _distance; // Distance in kilometers
    private double _speed; // Speed in kph
    private double _pace; // Pace in minutes per kilometer

    public Running(double minutes, double distance) : base(minutes)
    {
        _distance = distance;
        _pace = GetMinutes() / _distance; // Calculate pace in minutes per kilometer
        _speed = _distance / GetMinutes() * 60; // Calculate speed in kph
    }

    public override string GetName()
    {
        return _name;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _pace;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}