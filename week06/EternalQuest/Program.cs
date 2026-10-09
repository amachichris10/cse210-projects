using System;

// I showed creativity by adding a colorful animation when the user records
// a goal event. This includes a spinner and a congratulations text with the amount
// of points awarded.

public class Program
{
    private static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}