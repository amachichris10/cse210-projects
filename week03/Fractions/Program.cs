using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionA = new Fraction();
        Fraction fractionB = new Fraction(5);
        Fraction fractionC = new Fraction(3, 4);
        Fraction fractionD = new Fraction(1, 3);


        Console.WriteLine(fractionA.GetFractionString());
        Console.WriteLine(fractionA.GetDecimalValue());
        Console.WriteLine(fractionB.GetFractionString());
        Console.WriteLine(fractionB.GetDecimalValue());
        Console.WriteLine(fractionC.GetFractionString());
        Console.WriteLine(fractionC.GetDecimalValue());
        Console.WriteLine(fractionD.GetFractionString());
        Console.WriteLine(fractionD.GetDecimalValue());
    }
}