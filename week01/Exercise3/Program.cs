using System;

class Program
{
  static void Main(string[] args)
  {
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);
    int guess = -1;
    int counter = 0;

    do
    {
      Console.Write("What is your guess? ");
      string guessInput = Console.ReadLine();
      guess = int.Parse(guessInput);
      counter += 1;

      if (guess < magicNumber)
      {
        Console.WriteLine("Higher");
      }
      else if (guess > magicNumber)
      {
        Console.WriteLine("Lower");
      }
    } while (guess != magicNumber);

    Console.WriteLine("You guessed it!");
    Console.WriteLine($"It took you {counter} guesses to find it out.");
  }
}