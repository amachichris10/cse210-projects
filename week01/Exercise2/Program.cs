using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letterGrade = "";
        string sign = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade % 10 >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            sign = "+";
        }
        else if (grade % 10 <= 2 && letterGrade != "F")
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
        }
    }
}