using System;
using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _usedQuestions = new List<string>();
    private List<string> _prompts = new List<string>
    {
        "Think about a time when you showed great perseverance.",
        "Think about a time when you helped someone in need.",
        "Think about a time when you achieved a personal goal."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How can you apply what you learned to future situations?",
        "What strengths did you demonstrate during this experience?",
        "How did this experience impact your perspective on life?",
        "What would you do differently if faced with a similar situation in the future?",
        "How did this experience contribute to your personal growth?",
        "What emotions did you feel during this experience, and why?",
        "How did this experience affect your relationships with others?",
        "What advice would you give to someone facing a similar experience?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on things that are important to you.", 60)
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        GetDurationFromUser();

        Console.Clear();

        Console.WriteLine("Get ready to begin...\n");
        ShowCountdown(3);

        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowCountdown(5);

        Console.Clear();

        // Properly set the start and end time right before the loop begins
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
            Console.Write("\b \b");
            Console.WriteLine();
        }

        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        // Filter out used questions
        var availableQuestions = _questions.Where(q => !_usedQuestions.Contains(_questions.IndexOf(q).ToString())).ToList();
        
        Random random = new Random();
        int index = random.Next(availableQuestions.Count);
        _usedQuestions.Add(index.ToString()); // Store the index of the used question
        return availableQuestions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}