using System;

class Program
{
  static void Main(string[] args)
  {
    List<Activity> activities = new List<Activity>();

    activities.Add(new Running(new DateTime(2025, 10, 10), 30, 3.0));
    activities.Add(new Cycling(new DateTime(2025, 10, 11), 45, 15.0));
    activities.Add(new Swimming(new DateTime(2022, 10, 12), 60, 40));

    Console.WriteLine("Exercise Summary:\n");

    foreach (Activity activity in activities)
    {
      Console.WriteLine(activity.GetSummary());
    }
  }
}