using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetValue());

        Fraction f2 = new Fraction(8);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetValue());

        Fraction f3 = new Fraction(3, 2);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetValue());

        Fraction f4 = new Fraction(8, 2);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetValue());
    }
}