using System;
using System.Collections.Generic;

public class PromptGenerator
{
  public List<string> _prompts = new List<string> {
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "Who was the most interesting person I interacted with today?",
    "Describe a moment that made you smile today.",
    "Where did you feel most at peace today?",
    "When did you feel most alive today?",
    "Why did today matter?",
    "How did you grow as a person today?",
    "Who needs your prayers or thoughts tonight?",
    "What would you tell a friend about today?",
    "Describe the best conversation you had today.",
    "If today had a theme song, what would it be and why?",
    "What's something you're proud of from today?",
    "How did you show kindness today?",
    "What made you feel frustrated or challenged?",
    "When did you step outside your comfort zone?",
    "Describe something beautiful you noticed today.",
    "What are you grateful for right now?",
    "How could tomorrow be even better?",
    "What surprised you most about today?",
    "Describe a lesson you learned today.",
    "Who inspired you today and how?",
    "What's weighing on your mind tonight?",
    "How did you take care of yourself today?",
    "What small victory did you achieve?",
    "Describe your energy level throughout the day.",
    "What made you laugh the hardest today?",
    "If you could relive one moment from today, which would it be?"
  };

  public string GeneratePrompt()
  {
    int index = Random.Shared.Next(_prompts.Count);
    string choice = _prompts[index];

    return choice;
  }
}