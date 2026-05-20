using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        // No Parameter
        Fraction f1 = new Fraction();
        Console.WriteLine();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        // One Parameter
        Fraction f2 = new Fraction(5);
        Console.WriteLine();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        // Two Parameter 
        Fraction f3 = new Fraction(3,4);
        Console.WriteLine();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction();
        f5.SetTop(6);
        f5.SetBottom(7);
        Console.WriteLine();
        Console.WriteLine(f5.GetTop());
        Console.WriteLine(f5.GetBottom());
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        
    }
}