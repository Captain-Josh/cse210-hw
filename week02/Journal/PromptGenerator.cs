using System;
//Added random prompts 
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "Did i help anyone in need today?",
    "What made you smile today",
    "What challenge did you overcome today?",
    "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}