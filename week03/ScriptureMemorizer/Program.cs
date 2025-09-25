using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    // Load reference from file
    string filePath = "scriptures.csv";
    Random random = new Random();
    int randomNumber = random.Next(0, 10);
    string[] fileContent = File.ReadAllLines(filePath);
    string[] scriptureInfo = fileContent[randomNumber].Split("|");
    string book = scriptureInfo[0];
    int chapter = int.Parse(scriptureInfo[1]);
    int verse = int.Parse(scriptureInfo[2]);
    int endVerse = int.Parse(scriptureInfo[3]);
    string scriptureText = scriptureInfo[4];

    // create Reference and Scriputure
    Reference reference = new Reference(book, chapter, verse, endVerse);
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