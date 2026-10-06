using System;

class Swimming : Exercise
{
    private string _name = "Swimming";
    private int _poolLength = 50; // Length of the pool in meters
    private int _laps; // Number of laps swum

    public Swimming(int minutes, int laps):base(minutes)
    {
        _laps = laps;
    }

    public override string GetName()
    {
        return _name;
    }
    public override double GetDistance()
    {
        return _laps * _poolLength / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

}