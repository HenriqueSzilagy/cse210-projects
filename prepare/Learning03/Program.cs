using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Fraction f1 = new Fraction(); 
        Fraction f2 = new Fraction(3); 
        Fraction f3 = new Fraction(3, 5); 

        Fraction f4 = new Fraction();
        f4.SetTop(5);
        Console.WriteLine(f4.GetTop());

        Fraction f5 = new Fraction();
        f5.SetTop(3);
        f5.SetBottom(4);
        Console.WriteLine($"{f5.GetTop()} {f5.GetBottom()}");
        */
        Fraction f1 = new Fraction();
        f1.SetTop(1);
        f1.SetBottom(1);

        Fraction f2 = new Fraction();
        f2.SetTop(5);
        f2.SetBottom(1);

        Fraction f3 = new Fraction();
        f3.SetTop(3);
        f3.SetBottom(4);

        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(3);

    
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        
    }
}