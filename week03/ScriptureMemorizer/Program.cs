using System;

class Program
{
  static void Main(string[] args)
  {
    // create Reference instance
    string book = "Alma";
    int chapter = 37;
    int verse = 38;
    Reference reference = new Reference(book, chapter, verse);

    // create Scriptures
    string scriptureText = "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.";
    Scripture scripture = new Scripture(reference, scriptureText);

    // start program loop
    string quit = "";
    bool isCompletelyHidden = false;

    while (quit != "quit" && !isCompletelyHidden)
    {
      Console.Clear();
      string fullScripture = scripture.GetDisplayText();
      Console.WriteLine(fullScripture);
      Console.WriteLine();
      Console.WriteLine("Progress enter to continue or type 'quit' to finish:");
      quit = Console.ReadLine();
      isCompletelyHidden = scripture.IsCompletelyHidden();
      scripture.HideRandomWords(2);
    }
  }
}