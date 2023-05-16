using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionPt1 = new Fraction();
        Fraction fractionPt2 = new Fraction(5);
        Fraction fractionPt3 = new Fraction(3, 4);
        Fraction fractionPt4 = new Fraction(1, 3);

        Console.WriteLine(fractionPt1.GetFractionString());
        Console.WriteLine(fractionPt1.GetDecimalValue());
        Console.WriteLine(fractionPt2.GetFractionString());
        Console.WriteLine(fractionPt2.GetDecimalValue());
        Console.WriteLine(fractionPt3.GetFractionString());
        Console.WriteLine(fractionPt3.GetDecimalValue());
        Console.WriteLine(fractionPt4.GetFractionString());
        Console.WriteLine(fractionPt4.GetDecimalValue());
    }
}