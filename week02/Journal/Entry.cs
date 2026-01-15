public class Entry
{
  public string _date;
  public string _mood;
  public string _prompt;
  public string _response;

  // JsonSerializer.Deserialize fix
  public Entry() {}

  public Entry(string prompt, string response, string mood)
  {
    _date = DateTime.Now.ToString("MM/dd/yyyy");
    _mood = mood;
    _prompt = prompt;
    _response = response;
  }

  public void DisplayEntry()
  {
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Mood: {_mood}");
    Console.WriteLine($"Prompt: {_prompt}");
    Console.WriteLine($"Response: {_response}");
    Console.WriteLine();
  }
}