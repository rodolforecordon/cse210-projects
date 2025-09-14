public class PromptGenerator()
{
  public List<string> _prompts = [
    "How did I see the hand of the Lord in my life today?",
    "What was one thing you learned today?",
    "What is one thing you did well today?",
    "What is one thing you wish you do different tomorrow?",
    "What is one thing you are grateful that happened today?",
  ];

  public string GetRandomPrompt()
  {
    Random rand = new Random();
    int randIndex = rand.Next(5);
    return _prompts[randIndex];
  }
}