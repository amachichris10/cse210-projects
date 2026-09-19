// I showed creativity by creating a ScriptureLibrary class where I get a random scripture to display from a list of scriptures. It has private member variables, like the list of scriptures.
using System;

class Program
{
    
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        Scripture randomScripture = scriptureLibrary.GetRandomScripture();

        while (!randomScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            randomScripture.HideRandomWords(3); // Hide 3 random words each time
        }
    }
}