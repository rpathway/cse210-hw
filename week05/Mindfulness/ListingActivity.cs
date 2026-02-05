public class ListingActivity : Activity
{
  private int _count = 0;
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };

  public ListingActivity() : base(
    "Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
  ) {}

  public override void Run()
  {
    DisplayStartingMessage();
    Console.WriteLine("\nList as many responses you can to the following prompt, leave a line blank to finish.");
    
    GetRandomPrompt();
    
    Console.Write("\nYou may begin in: ");
    ShowCountDown(5);

    List<string> items = GetListFromUser();
    _count = items.Count;
    
    Console.WriteLine($"\nYou listed {_count} items!");

    DisplayEndingMessage();
  }

  public void GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    string choice = _prompts[index];
    
    Console.WriteLine($"== {choice} ==");
  }

  public List<string> GetListFromUser()
  {
    List<string> items = new List<string>();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    Console.WriteLine();
    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string userInput = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(userInput))
      {
        break;
      }

      items.Add(userInput);
    }

    return items;
  }
}