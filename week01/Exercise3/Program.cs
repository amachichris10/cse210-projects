using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        
        

        
        do
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int totalGuesses = 0;
            do
            {
                Console.Write("What is your guess? ");
                userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                totalGuesses++;

                if (guess == magicNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the magic number!");
                    Console.WriteLine($"It took you {totalGuesses} guesses.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again!");
                }

            } while (guess != magicNumber);

            Console.Write("Do you want to play again? (yes/no) ");
            userInput = Console.ReadLine();

        } while (userInput.ToLower() == "yes");

    }
}