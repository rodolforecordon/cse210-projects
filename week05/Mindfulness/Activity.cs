public class Activity
{
  protected string _name;
  protected string _description;
  private int _duration;

  public Activity()
  {
    _name = "";
    _description = "";
    _duration = 0;
  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();
    Console.WriteLine("How long, in seconds, would you like for your session? ");
    int seconds = int.Parse(Console.ReadLine());
    SetDuration(seconds);

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(5);
    Console.WriteLine();
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine("Well done!!");
    ShowSpinner(5);
  }

  public void ShowSpinner(int seconds)
  {
    List<string> spinnerChars = ["|", "/", "-", "\\"];
    for (double i = seconds; i > 0; i -= 2)
    {
      foreach (string character in spinnerChars)
      {
        Console.Write(character);
        Thread.Sleep(500);
        Console.Write("\b \b");
      }
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

  private void SetDuration(int seconds)
  {
    _duration = seconds;
  }

  public int GetDuration()
  {
    return _duration;
  }
}