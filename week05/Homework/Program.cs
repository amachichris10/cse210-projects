using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assignment = new Assignment("Cristofer Amachi", "C# Programming");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Cristofer Amachi", "C# Programming", "3.2", "1-10");
        Console.WriteLine("\n" + mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Cristofer Amachi", "C# Programming", "The Importance of Learning C#");
        Console.WriteLine("\n" + writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}