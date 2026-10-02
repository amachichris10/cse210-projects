using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by focusing on your breath.", 60)
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        GetDurationFromUser();

        Console.WriteLine("Get ready to begin...");
        ShowCountdown(3);
        
        // Properly set the start and end time right before the loop begins
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountdown(4);
        }

        DisplayEndMessage();
    }
}