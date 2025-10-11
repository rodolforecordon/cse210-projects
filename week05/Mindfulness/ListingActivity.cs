using System.Diagnostics;

public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  public ListingActivity()
  {
    _name = "Listing Activity";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    _prompts = [
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?",
    ];
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine($" --- {GetRandomPrompt()} ---");
    Console.Write("You may begin in: ");
    ShowCountDown(5);

    _count = GetListFromUser().Count;

    Console.WriteLine($"You listed {_count} items!");

    DisplayEndingMessage();
  }

  private string GetRandomPrompt()
  {
    Random random = new Random();
    int randNum = random.Next(_prompts.Count - 1);
    return _prompts[randNum];
  }

  private List<string> GetListFromUser()
  {
    double totalDuration = 0;
    List<string> userList = [];

    Console.WriteLine();

    while (GetDuration() > totalDuration)
    {
      Console.Write("> ");
      Stopwatch stopwatch = Stopwatch.StartNew();
      string response = Console.ReadLine();
      stopwatch.Stop();
      double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;

      userList.Add(response);

      totalDuration += elapsedSeconds;
    }

    return userList;
  }
}