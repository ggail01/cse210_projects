using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine();

        Fraction f2 = new Fraction(8);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine();
    }
}