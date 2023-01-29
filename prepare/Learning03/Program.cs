using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(3, 4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(1, 3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
    
}