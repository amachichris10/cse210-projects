using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that you are grateful for.",
        "List as many people as you can that have positively impacted your life.",
        "List as many accomplishments as you can that you are proud of."
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on things you are grateful for.", 60)
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        GetDurationFromUser();
        Console.Clear();

        GetRandomPrompt();
        Console.WriteLine("Get ready to begin...\n");
        ShowCountdown(5);

        // Properly set the start and end time right before the loop begins
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);

        GetListFromUser();
        DisplayEndMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
    
    private void GetListFromUser()
    {
        _count = 0;
        Console.WriteLine("Start listing your items");
        while (DateTime.Now < _endTime)
        {
            string input = Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items.");
        Thread.Sleep(2000); // Pause for 2 seconds to allow the user to read the count
    }
}