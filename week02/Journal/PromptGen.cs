using System;
using System.Collections.Generic;
// prompt generator. I cooudl not assist the group meeting so I tried my best

public class PromptGen
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "Did I struggle with some emotion?",
        "If I had one thing I could do over today, what would it be?",
        "Just write three things to be grateful for:"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}