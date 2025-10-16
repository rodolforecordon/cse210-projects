using System;
using System.IO;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = [];
    _score = 0;
  }

  public void Start()
  {
    List<string> menu = [
      "Create New Goal",
      "List Goals",
      "Save Goals",
      "Load Goals",
      "Record Event",
      "Quit",
    ];
    int option = 0;

    while (option != 6)
    {
      DisplayPlayerInfo();

      Console.WriteLine("Menu Options:");

      for (int i = 0; i < menu.Count; i++)
      {
        Console.WriteLine($"  {i + 1}. {menu[i]}");
      }

      Console.Write("Select a choice from the menu: ");
      option = int.Parse(Console.ReadLine());

      if (option == 1)
      {
        CreateGoal();
      }

      if (option == 2)
      {
        ListGoalDetails();
      }

      if (option == 3)
      {
        SaveGoals();
      }

      if (option == 4)
      {
        LoadGoals();
      }

      if (option == 5)
      {
        RecordEvent();
      }
    }
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine();
    Console.WriteLine($"You have {_score} points");
    Console.WriteLine();
  }

  public void ListGoalNames()
  {
    Console.WriteLine();
    Console.WriteLine("The goals are: ");

    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
    }
  }

  public void ListGoalDetails()
  {
    Console.WriteLine();
    Console.WriteLine("The goals are:");

    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine(_goals[i].GetDetailsString());
    }
  }

  public void CreateGoal()
  {
    List<string> typesOfGoals = [
      "Simple Goal",
      "Eternal Goal",
      "Checklist Goal",
    ];
    int option;
    string name;
    string description;
    string points;
    int target;
    int bonus;

    Console.WriteLine();
    Console.WriteLine("The types of Goals are: ");

    for (int i = 0; i < typesOfGoals.Count; i++)
    {
      Console.WriteLine($"  {i + 1}. {typesOfGoals[i]}");
    }

    Console.Write("Which type of goal would you like to create: ");
    option = int.Parse(Console.ReadLine());

    Console.Write("What is the name of your goal? ");
    name = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    description = Console.ReadLine();

    Console.Write("What is the amount of points associated with it? ");
    points = Console.ReadLine();

    if (option == 1)
    {
      Goal simple = new SimpleGoal(name, description, points);
      _goals.Add(simple);
    }

    if (option == 2)
    {
      Goal eternal = new EternalGoal(name, description, points);
      _goals.Add(eternal);
    }

    if (option == 3)
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for accomplishing it that many times? ");
      bonus = int.Parse(Console.ReadLine());
      Goal checklist = new ChecklistGoal(name, description, points, target, bonus);
      _goals.Add(checklist);
    }

    Console.WriteLine();
  }

  public void RecordEvent()
  {
    Console.WriteLine();

    ListGoalNames();

    Console.Write("Which goal did you accomplish? ");
    int option = int.Parse(Console.ReadLine());
    Goal currentGoal = _goals[option - 1];

    currentGoal.RecordEvent();
    _score += int.Parse(currentGoal._points);

    Console.WriteLine($"Congratulations! You have earned {currentGoal._points} points");
  }

  public void SaveGoals()
  {
    Console.WriteLine();
    Console.Write("What is the name of the goals storage file? ");
    string filename = Console.ReadLine();
    // initialize content variable with the _score
    string content = $"{_score}" + Environment.NewLine;
    foreach (Goal goal in _goals)
    {
      content += goal.GetStringRepresentation() + Environment.NewLine;
    }
    File.WriteAllText(filename, content);
  }

  public void LoadGoals()
  {
    Console.WriteLine();
    Console.Write("What is the name of the goals storage file? ");
    string filename = Console.ReadLine();
    string[] content = File.ReadAllLines(filename);

    _score = int.Parse(content[0]);
    _goals = [];

    for (int i = 1; i < content.Count(); i++)
    {
      string[] goalSplit = content[i].Split(":");
      string goalType = goalSplit[0];
      string[] goalAttributes = goalSplit[1].Split(",");

      if (goalType == "SimpleGoal")
      {
        Goal simple = new SimpleGoal(goalAttributes[0], goalAttributes[1], goalAttributes[2]);
        bool isComplete = bool.Parse(goalAttributes[3]);
        if (isComplete) simple.RecordEvent();
        _goals.Add(simple);
      }

      if (goalType == "EternalGoal")
      {
        Goal eternal = new EternalGoal(goalAttributes[0], goalAttributes[1], goalAttributes[2]);
        _goals.Add(eternal);
      }

      if (goalType == "ChecklistGoal")
      {
        Goal checklist = new ChecklistGoal(
          goalAttributes[0],
          goalAttributes[1],
          goalAttributes[2],
          int.Parse(goalAttributes[3]),
          int.Parse(goalAttributes[4]),
          int.Parse(goalAttributes[5])
        );
        _goals.Add(checklist);
      }
    }
  }
}