public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  public void Run()
  {
    DisplayStartingMessage();

    int totalDuration = 0;
    int breathInDuration = 4;
    int breathOutDuration = 8;

    while (GetDuration() > totalDuration)
    {
      Console.Write("Breath in... ");
      ShowCountDown(breathInDuration);
      Console.WriteLine();

      Console.Write("Breath out... ");
      ShowCountDown(breathOutDuration);
      Console.WriteLine();

      totalDuration += breathInDuration + breathOutDuration;
    }

    DisplayEndingMessage();
  }
}