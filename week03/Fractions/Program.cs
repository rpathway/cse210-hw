using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(1);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction = new Fraction(5);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction = new Fraction(3, 4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        fraction = new Fraction(1, 3);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}