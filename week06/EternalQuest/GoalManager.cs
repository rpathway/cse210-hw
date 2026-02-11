public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    string choice = "";
    while (choice != "6")
    {
      DisplayPlayerInfo();
      Console.WriteLine("\nMenu Options:");
      Console.WriteLine("1. Create new goal");
      Console.WriteLine("2. List goals");
      Console.WriteLine("3. Save goals");
      Console.WriteLine("4. Load goals");
      Console.WriteLine("5. Record event");
      Console.WriteLine("6. Quit");
      Console.Write(" > ");
      choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          CreateGoal();
          break;
        case "2":
          ListGoalNames();
          break;
        case "3":
          SaveGoals();
          break;
        case "4":
          LoadGoals();
          break;
        case "5":
          RecordEvent();
          break;
        case "6":
          Console.WriteLine("Goodbye.");
          break;
        default:
          Console.WriteLine("Invalid choice. Please select between 1-6.");
          break;
      }
    }
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"\nYou have {_score} points!");
    int level = GetLevel();
    string rank = GetRank(level);

    Console.WriteLine($"Level: {level} - {rank}");
  }

  public void ListGoalNames()
  {
    Console.WriteLine("\nThe goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }
  }

  public void ListGoalDetails()
  {
    ListGoalNames();
  }

  public void CreateGoal()
  {
    Console.WriteLine("\nThe types of Goals are: ");
    Console.WriteLine("1. Simple goal");
    Console.WriteLine("2. Eternal goal");
    Console.WriteLine("3. Checklist goal");
    Console.Write("Which goal would you like to create?");
    int goalType = int.Parse(Console.ReadLine());

    Console.Write("What is the name of your goal? ");
    string goalName = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string goalDesc = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal? ");
    int goalPoints = int.Parse(Console.ReadLine());

    Goal newGoal = null;

    switch (goalType)
    {
      case 1:
        newGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
        break;
      case 2:
        newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
        break;
      case 3:
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        newGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, target, bonus);
        break;
    }

    if (newGoal != null)
    {
      _goals.Add(newGoal);
    }
  }

    public void RecordEvent()
    {
      ListGoalNames();
      Console.Write("Which goal did you accomplish? ");
      int goalIndex = int.Parse(Console.ReadLine()) - 1;

      if (goalIndex >= 0 && goalIndex < _goals.Count)
      {
        Goal goal = _goals[goalIndex];
        
        if (goal.IsComplete())
        {
          Console.WriteLine("This goal is already complete!");
        }
        else
        {
          goal.RecordEvent();
          int pointsEarned = goal.GetPoints();
          _score += pointsEarned;

          Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
          Console.WriteLine($"You now have {_score} points.");

          CheckLevelUp();
        }
      }
      else
      {
        Console.WriteLine("Invalid goal number.");
      }
    }

    public void SaveGoals()
    {
      Console.Write("What is the filename? ");
      string filename = Console.ReadLine();

      using (StreamWriter outputFile = new StreamWriter(filename))
      {
        outputFile.WriteLine(_score);

        foreach (Goal goal in _goals)
        {
          outputFile.WriteLine(goal.GetStringRepresentation());
        }
      }

      Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
      Console.Write("What is the filename? ");
      string filename = Console.ReadLine();

      if (File.Exists(filename))
      {
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
          string[] parts = lines[i].Split(":");
          string goalType = parts[0];
          string[] details = parts[1].Split(",");

          Goal goal = null;

          switch (goalType)
          {
            case "SimpleGoal":
              goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3]));
              break;
            case "EternalGoal":
              goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
              break;
            case "ChecklistGoal":
              goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[3]), int.Parse(details[5]));
              break;
          }

          if (goal != null)
          {
            _goals.Add(goal);
          }
        }

        Console.WriteLine("Goals loaded successfully!");
      }
      else
      {
        Console.WriteLine("File not found!");
      }
    }

    private int GetLevel()
    {
      return (_score / 1000) + 1;
    }

    private string GetRank(int level)
    {
      if (level >= 20) return "Celestial Champion";
      if (level >= 15) return "Divine Warrior";
      if (level >= 10) return "Sacred Knight";
      if (level >= 7)  return "Noble Seeker";
      if (level >= 5)  return "Faithful Pilgrim";
      if (level >= 3)  return "Humble Servant";
      
      return "New Adventurer";
    }

    private void CheckLevelUp()
    {
      int level = GetLevel();
      int pointsIntoCurrentLevel = _score % 1000;

      if (pointsIntoCurrentLevel < 200)
      {
        Console.WriteLine($"\n*** LEVEL UP! You are now Level {level}: {GetRank(level)} ***");
      }
    }

}