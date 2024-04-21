using System;

class clsCalculator
{
    private float Result
    {
        get;
        set;
    }

    private string LastOp
    {
        get;
        set;
    }

    private float LastNumber
    {
        get;
        set;
    }

    public void Add(float Number)
    {
        Result += Number;
        LastOp = "adding";
        LastNumber = Number;
    }

    public void Subtract(float Number)
    {
        Result -= Number;
        LastOp = "subtracting";
        LastNumber = Number;

    }

    public void Divide(float Number)
    {
        if (Result == 0)
        {
            Result = 1;
        }

        Result /= Number;
        LastOp = "dividing";
        LastNumber = Number;

    }


    public void Multiply(float Number)
    {
        Result *= Number;
        LastOp = "multiplying";
        LastNumber = Number;

    }

    public void Clear()
    {
        Result = 0;
    }
    public void PrintResult()
    {
        Console.WriteLine($"Result after {LastOp} {LastNumber} is: {Result}");
    }
}

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calc1 = new clsCalculator();
            Calc1.Add(10);
            Calc1.PrintResult();
            Calc1.Subtract(10);
            Calc1.PrintResult();
            Calc1.Add(30);
            Calc1.PrintResult();
            Calc1.Divide(10);
            Calc1.Multiply(9);
            Calc1.PrintResult();
        }
    }
}


