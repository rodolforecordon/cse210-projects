public class SimpleGoal : Goal
{
  bool _isComplete;

  public SimpleGoal(string name, string description, string points) : base(name, description, points)
  {
    _isComplete = false;
  }

  public override void RecordEvent()
  {
    _isComplete = true;
  }

  public override bool isComplete()
  {
    return _isComplete;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
  }
}