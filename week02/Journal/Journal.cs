using System.Text.Json;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();
  private string _journalFolder = Path.Combine(Directory.GetCurrentDirectory(), "journals");
  private string _indexFile = Path.Combine(Directory.GetCurrentDirectory(), "journals", "journalIndex.json");
  private JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { IncludeFields = true };

  public Journal()
  {
    if (!Directory.Exists(_journalFolder))
    {
      Directory.CreateDirectory(_journalFolder);
    }
  }

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
  }

  public void DisplayAllEntries()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("No entries logged.");
      return;
    }

    Console.WriteLine();

    foreach (Entry entry in _entries)
    {
      entry.DisplayEntry();
    }
  }

  public void SaveToFile(string filename)
  {
    if (!filename.EndsWith(".json"))
    {
      filename += ".json";
    }

    string filepath = Path.Combine(_journalFolder, filename);
    string jsonString = JsonSerializer.Serialize(_entries, _jsonOptions);
    File.WriteAllText(filepath, jsonString);

    AddToDatabase(filename);

    Console.WriteLine($"Saved to {filename}");
  }

  private void AddToDatabase(string filename)
  {
    List<string> index = new List<string>();

    if (File.Exists(_indexFile))
    {
      string indexJson = File.ReadAllText(_indexFile);
      index = JsonSerializer.Deserialize<List<string>>(indexJson);
    }

    if (!index.Contains(filename))
    {
      index.Add(filename);
      string updatedJson = JsonSerializer.Serialize(index, new JsonSerializerOptions { WriteIndented = true });
      File.WriteAllText(_indexFile, updatedJson);
    }
  }

  public void LoadFromFile(string filename)
  {
    if (!filename.EndsWith(".json"))
    {
      filename += ".json";
    }

    string filepath = Path.Combine(_journalFolder, filename);

    if (!File.Exists(filepath))
    {
      Console.WriteLine($"File not found: {filename}");
      return;
    }

    string jsonString = File.ReadAllText(filepath);
    _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString, _jsonOptions);

    Console.WriteLine($"Loaded: {_entries.Count} entries from {filename}\n");
  }

  public List<string> GetSavedFiles()
  {
    if (!File.Exists(_indexFile))
    {
      return new List<string>();
    }

    string indexJson = File.ReadAllText(_indexFile);
    return JsonSerializer.Deserialize<List<string>>(indexJson);
  }

  public void DisplaySavedFiles()
  {
    List<string> files = GetSavedFiles();

    if (files.Count == 0)
    {
      Console.WriteLine("No saved journals found.");

      return;
    }

    Console.WriteLine("\nSaved journals:");

    for (int i = 0; i < files.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {files[i]}");
    }
  }
}