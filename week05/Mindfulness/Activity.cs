using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done! You have completed the {_name} Activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void GetDurationFromUser()
    {
        int duration = 0;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Enter duration for this activity (in seconds): ");
            string input = Console.ReadLine();

            // Check if it's a valid integer AND greater than 0
            if (int.TryParse(input, out duration) && duration > 0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }
        }

        _duration = duration; // Update the duration for this activity
    }

    public void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}