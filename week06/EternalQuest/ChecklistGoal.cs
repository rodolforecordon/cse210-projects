using System.Net;

public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, string points, int target, int bonus)
    : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = 0;
  }

  public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted)
  : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = amountCompleted;
  }

  public override void RecordEvent()
  {
    if (_amountCompleted < _target)
    {
      _amountCompleted++;
    }

    if (_amountCompleted == _target)
    {
      _points = $"{int.Parse(_points) + _bonus}";
    }
  }

  public override bool isComplete()
  {
    return _amountCompleted >= _target;
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
  }

  public override string GetDetailsString()
  {
    string checkmark = isComplete() ? "X" : " ";
    return $"[{checkmark}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
  }
}