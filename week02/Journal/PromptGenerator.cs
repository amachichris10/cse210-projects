using System;

class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "Write about a memorable moment from your day.",
        "What is something new you learned today?",
        "Reflect on a goal you are working towards."
    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}