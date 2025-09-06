using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    int number = -1;
    List<int> numbers = new List<int>();

    while (number != 0)
    {
      Console.Write("Enter number: ");
      number = int.Parse(Console.ReadLine());
      if (number != 0)
      {
        numbers.Add(number);
      }
    }

    // Total
    int total = 0;

    for (int i = 0; i < numbers.Count; i++)
    {
      total += numbers[i];
    }

    // Average
    float avg = (float)total / numbers.Count;

    // Largest Number
    int largestNumber = -99999999;

    for (int i = 0; i < numbers.Count; i++)
    {
      if (numbers[i] > largestNumber)
      {
        largestNumber = numbers[i];
      }
    }

    // Display
    Console.WriteLine($"The sum is: {total}");
    Console.WriteLine($"The average is: {avg}");
    Console.WriteLine($"The largest number is: {largestNumber}");
  }
}