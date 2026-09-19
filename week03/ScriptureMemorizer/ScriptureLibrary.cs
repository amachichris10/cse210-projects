using System;

class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        // Add scriptures to the library
        _scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        _scriptures.Add(new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I lack nothing."));
        _scriptures.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."));
        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
    }
    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}