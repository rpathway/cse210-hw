public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };
  private List<string> _questions = new List<string>
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };
  private List<string> _unusedQuestions;

  public ReflectingActivity() : base(
    "Reflecting Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
  {
    _unusedQuestions = new List<string>(_questions);
  }

  public override void Run()
  {
    DisplayStartingMessage();
    Console.WriteLine("\nConsider the following prompt:\n");

    DisplayPrompt();

    Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
    Console.Write("You may begin in: ");

    ShowCountDown(5);

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      DisplayQuestion();
      ShowSpinner(15);
    }

    DisplayEndingMessage();
  }

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int choice = random.Next(_prompts.Count);

    return _prompts[choice];
  }

  public string GetRandomQuestion()
  {
    if (_unusedQuestions.Count == 0)
    {
      _unusedQuestions = _questions;
    }

    Random random = new Random();
    int choice = random.Next(_unusedQuestions.Count);
    string question = _unusedQuestions[choice];
    _unusedQuestions.RemoveAt(choice);

    return question;
  }

  public void DisplayPrompt()
  {
    string choice = GetRandomPrompt();
    Console.WriteLine($"== {choice} ==");
  }

  public void DisplayQuestion()
  {
    string question = GetRandomQuestion();
    Console.Write($"\n\n> {question} ");
  }
}