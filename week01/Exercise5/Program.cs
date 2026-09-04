using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string name = UserName();
        int number = UserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, number, squared);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int UserNumber()
    {
        Console.Write("Please enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int number, int squared)
    {
        Console.WriteLine($"{name}, the square of {number} is {squared}.");
    }
}