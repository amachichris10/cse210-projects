using System;

// To show creativity, I did add the feature of storing my data in JSON
// instead of raw text. This allows me to store my data in a structured 
// format, making it easier to read and manipulate later on.
// I also added the ability to load my journal entries from a JSON file, 
// which allows me to easily access my past entries 
// and reflect on my progress over time.

// Since I'm using variables in the Entry class, 
// I had to add the IncludeFields option in the JsonSerializerOptions.
// This allowed me to take into account those variables or fields.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry entry = new Entry(date, prompt, entryText);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}