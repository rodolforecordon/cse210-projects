public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity()
  {
    _name = "Reflecting Activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _prompts = [
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
    ];
    _questions = [
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?",
    ];
  }

  public void Run()
  {
    DisplayStartingMessage();

    DisplayPrompt();

    DisplayQuestions();

    DisplayEndingMessage();
  }

  private string GetRandomPrompt()
  {
    Random random = new Random();
    int randNum = random.Next(_prompts.Count - 1);
    return _prompts[randNum];
  }

  private string GetRandomQuestion()
  {
    Random random = new Random();
    int randNum = random.Next(_questions.Count - 1);
    return _questions[randNum];
  }

  private void DisplayPrompt()
  {
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();
  }

  private void DisplayQuestions()
  {
    int totalDuration = 0;
    int spinnerDuration = 5;
    List<string> displayedQuestions = [];

    while (GetDuration() > totalDuration)
    {
      string randomQuestion = GetRandomQuestion();

      if (displayedQuestions.Contains(randomQuestion))
      {
        break;
      }

      displayedQuestions.Add(randomQuestion);

      Console.WriteLine($"> {randomQuestion}");
      ShowSpinner(spinnerDuration);

      totalDuration += spinnerDuration;
    }
  }


}