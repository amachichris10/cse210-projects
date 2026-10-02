using System;

// To show creativity in my project, I've added a filter on ReflectingActivity
// to ensure that the same question is not asked twice during a single session. 
// This encourages deeper reflection and prevents repetition, enhancing the 
// mindfulness experience.

// I also added input validation for the duration of each activity, ensuring that
// users enter a valid number greater than 0. This prevents potential errors and
// ensures a smoother user experience.

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        Console.Clear();

        while (input != "4")
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter the number of your choice: ");

            input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.Write("Enter the number of your choice: ");
                input = Console.ReadLine();
            }

            if (input == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }

            if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
        }
    }
}