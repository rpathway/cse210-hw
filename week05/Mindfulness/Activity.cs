public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}.\n");
    Console.WriteLine(_description);
    Console.Write("\nHow long would you like your session to be (seconds)? ");

    string userDuration = Console.ReadLine();
    _duration = int.Parse(userDuration);

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(3);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("\nWell done!!");
    ShowSpinner(3);

    Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
    ShowSpinner(3);
  }

  public void ShowSpinner(int seconds)
  {
    List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;
    while (DateTime.Now < endTime)
    {
      string spinnerChar = animationStrings[i];
      Console.Write(spinnerChar);

      Thread.Sleep(200);
      Console.Write("\b \b");

      i = (i + 1) % animationStrings.Count;
    }
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }

  public virtual void Run() {}
}