using System;

class Program
{
  static void Main(string[] args)
  {
    Fraction fraction1 = new Fraction();
    Fraction fraction2 = new Fraction(5);
    Fraction fraction3 = new Fraction(5, 2);

    Console.WriteLine(fraction1.GetFractionString());
    Console.WriteLine(fraction2.GetFractionString());
    Console.WriteLine(fraction3.GetFractionString());

    Console.WriteLine($"old top {fraction1.GetTop()}");
    fraction1.SetTop(3);
    Console.WriteLine($"new top {fraction1.GetTop()}");

    Console.WriteLine($"old bottom {fraction1.GetBottom()}");
    fraction1.SetBottom(2);
    Console.WriteLine($"new bottom {fraction1.GetBottom()}");

    Console.WriteLine(fraction1.GetDecimalValue());

    // Sample code tests
    Console.WriteLine();
    Console.WriteLine("### Sample Solution Tests ###");

    Fraction f1 = new Fraction();
    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f1.GetDecimalValue());

    Fraction f2 = new Fraction(5);
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f2.GetDecimalValue());

    Fraction f3 = new Fraction(3, 4);
    Console.WriteLine(f3.GetFractionString());
    Console.WriteLine(f3.GetDecimalValue());

    Fraction f4 = new Fraction(1, 3);
    Console.WriteLine(f4.GetFractionString());
    Console.WriteLine(f4.GetDecimalValue());
  }
}
