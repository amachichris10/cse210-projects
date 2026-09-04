using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        float average = 0;
        int max = 0;
        int smallestNegative = 0;

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);

                if (number > max)
                {
                    max = number;
                }

                // smallest negative number
                if (number < 0 && (smallestNegative == 0 || number > smallestNegative))
                {
                    smallestNegative = number;
                }

            }
            
        } while (number != 0);
        
        foreach (int n in numbers)
        {
            sum += n;
        }
        average = (float)sum / numbers.Count;
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Smallest Negative: " + smallestNegative);
    }
}