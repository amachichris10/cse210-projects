using System;

class Cycling : Exercise
{
    private string _name = "Cycling";
    private double _speed; // Speed in kilometers per hour
    private double _pace; // Pace in minutes per kilometer
    private double _distance; // Distance in kilometers

    public Cycling(double minutes, double speed) : base(minutes)
    {
        _speed = speed;
        _distance = _speed * GetMinutes() / 60; // Calculate distance based on speed and time
        _pace = GetMinutes() / _distance; // Calculate pace in minutes per kilometer
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