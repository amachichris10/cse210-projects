using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Cristofer Amachi", "C# Programming");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Cristofer Amachi", "C# Programming", "Section 3.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}