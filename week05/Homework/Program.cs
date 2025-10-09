using System;

class Program
{
  static void Main(string[] args)
  {
    Assignment homework1 = new Assignment("Samuel Bennett", "Multiplication");
    Console.WriteLine(homework1.GetSummary());
    Console.WriteLine();

    MathAssignment homework2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
    Console.WriteLine(homework2.GetSummary());
    Console.WriteLine(homework2.GetHomeworkList());
    Console.WriteLine();

    WritingAssignment homework3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
    Console.WriteLine(homework3.GetSummary());
    Console.WriteLine(homework3.GetWritingInformation());
  }
}