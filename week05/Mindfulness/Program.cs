using System;

class Program
{
  static void Main(string[] args)
  {
    List<string> menu = [
      "Start breathing activity",
      "Start reflecting activity",
      "Start listing activity",
      "Quit"
    ];
    int option = -1;

    while (option != 4)
    {
      Console.Clear();
      Console.WriteLine("Menu Options:");

      for (int i = 0; i < menu.Count; i++)
      {
        Console.WriteLine($"  {i + 1}. {menu[i]}");
      }

      Console.Write("Select a choice from the menu: ");
      option = int.Parse(Console.ReadLine());

      if (option == 1)
      {
        BreathingActivity activity = new BreathingActivity();
        activity.Run();
      }

      if (option == 2)
      {
        ReflectingActivity activity = new ReflectingActivity();
        activity.Run();
      }

      if (option == 3)
      {
        ListingActivity activity = new ListingActivity();
        activity.Run();
      }
    }
  }
}