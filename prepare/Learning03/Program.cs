using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(7,6);

        fraction3.SetTop(25);
        fraction3.SetBottom(25);

        Console.WriteLine($"{fraction3.GetTop()}");
        Console.WriteLine($"{fraction3.GetBottom()}");

        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");
    }
}