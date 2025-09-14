using System;

class Program
{
  static void Main(string[] args)
  {
    int option = -1;
    Journal journal = new Journal();

    Console.WriteLine("###### Welcome to your journal! ######");
    Console.WriteLine();

    while (option != 5)
    {
      Console.WriteLine("Choose one of the following options:");
      Console.WriteLine("  1. Write");
      Console.WriteLine("  2. Display");
      Console.WriteLine("  3. Save");
      Console.WriteLine("  4. Load");
      Console.WriteLine("  5. Quit");
      Console.Write("What would you like to do? ");
      option = int.Parse(Console.ReadLine());

      if (option < 1 | option > 5)
      {
        Console.WriteLine("Choose a valid option (1-5).");
        continue;
      }

      if (option == 1)
      {
        // create entry instance
        Entry newEntry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        newEntry._promptText = prompt.GetRandomPrompt();
        newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");

        // request prompt from user and add Entry
        Console.WriteLine(newEntry._promptText);
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();
        journal.AddEntry(newEntry);
      }

      if (option == 2)
      {
        journal.DisplayAll();
      }

      if (option == 3)
      {
        journal.SaveToDB();
      }

      if (option == 4)
      {
        journal.LoadFromDB();
      }
    }
  }
}