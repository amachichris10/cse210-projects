using System;

abstract class Exercise
{
    private DateTime _date;
    private double _minutes; // Time in minutes

    public Exercise(double minutes)
    {
        _date = DateTime.Today;
        _minutes = minutes;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {GetName()} ({GetMinutes()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace():F2} min/km");
    }


    public double GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date.ToString("dd MMM yyyy");
    }

    public abstract string GetName();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}