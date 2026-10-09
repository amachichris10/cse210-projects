using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading; // Required for Thread.Sleep

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to EternalQuest!");
        Console.WriteLine("You are a brave adventurer on a quest to achieve your goals.");
        Console.WriteLine("Score: " + _score);
        Console.WriteLine("Let's begin your journey!");

        // Main game loop
        while (true)
        {
            Console.WriteLine("Score: " + _score);
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List all goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalsDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Thank you for playing EternalQuest! Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Player Information:");
        Console.WriteLine("Current Score: " + _score);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your current goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. " + goal.GetName());
        }
    }
    
    public void ListGoalsDetails()
    {
        Console.WriteLine("Your current goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select a choice from the menu:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            choice = Console.ReadLine();
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is the description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the points value of your goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                Console.Write("What is the target count for your checklist goal? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus points for completing your checklist goal? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Your current goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine("Which goals did you accomplish? ");
        string number = Console.ReadLine();

        if (int.TryParse(number, out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            Goal goal = _goals[goalIndex - 1];
            goal.RecordEvent();
            _score += goal.GetPoints();
            // Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points.");
            AnimatePointsEarned(goal.GetPoints());
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }

    private void AnimatePointsEarned(int points)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\n[+] Processing achievement ");

        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < 12; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        Console.Clear();
        Console.WriteLine();
        
        ConsoleColor[] colors = { ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Green };

        for (int i = 0; i < colors.Length; i++)
        {
            Console.ForegroundColor = colors[i];
            Console.WriteLine("  🎉 CONGRATULATIONS! 🎉");
            Console.WriteLine($"      +{points} POINTS!      ");
            Thread.Sleep(150);

            // Check if this is NOT the last frame by index position
            if (i < colors.Length - 1)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
            }
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save goals:");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved to " + filename);
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load goals:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found: " + filename);
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split('|');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    int targetCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    for (int i = 0; i < currentCount; i++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                    break;
                default:
                    Console.WriteLine("Unknown goal type: " + goalType);
                    break;
            }
        }
    }
}