using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("What is your grade percentage (do not write the % character)? ");
    string grade = Console.ReadLine();
    int gradePercentage = int.Parse(grade);
    string letter;


    if (gradePercentage >= 90)
    {
      letter = "A";
    }
    else if (gradePercentage >= 80)
    {
      letter = "B";
    }
    else if (gradePercentage >= 70)
    {
      letter = "C";
    }
    else if (gradePercentage >= 60)
    {
      letter = "D";
    }
    else
    {
      letter = "F";
    }

    Console.WriteLine($"Your letter grade is {letter}.");

    if (letter == "A" || letter == "B" || letter == "C")
    {
      Console.WriteLine("Congratulations! You passed.");
    }
    else
    {
      Console.WriteLine("Keep tying. You will get it next time.");
    }
  }
}