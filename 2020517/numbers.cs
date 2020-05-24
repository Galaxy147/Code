using System;

public class YunSuan
{ 
    public void ZhengShu()
    {
        int b = 6;
        int a = 4;
        int num1 = a + b;
        int num2 = a * b;
        int num3 = b / a;
        Console.WriteLine($"a = {a},b ={b}");
        Console.WriteLine($"a + b ={num1}");
        Console.WriteLine($"a * b ={num2}");
        Console.WriteLine($"b / a ={num3}");
        Console.ReadKey();
    }
    
    public void ChufaheYushu()
    {
        int a = 4;
        int b = 6;
        int c = a / b;
        int d = a % b;
        Console.WriteLine($"a is 4 and the b is 6, a / b = {c}");
        Console.WriteLine($"And least {d}");
        Console.ReadKey();
    }

    public void MaxMinInt()
    {
        int max = int.MaxValue;
        int min = int.MinValue;
        int overflow = max + 3;
        Console.WriteLine($"The max value of Int is {max}");
        Console.WriteLine($"The min value of Int is {min}");
        Console.WriteLine($"An example of overflow(max + 3):{overflow}");
        Console.ReadKey();
    }

    public void Double()
    {
        double a = 13; // double a = 13.0
        double b = 17; // double b = 17.0
        double c = a / b;
        double max = double.MaxValue;
        double min = double.MinValue;
        Console.WriteLine($"13 / 17 = {c}");
        // The printed values are expressed in scientific notation. E significant numbers to the left. On the right is the nth power of 10.
        Console.WriteLine($"Double's maximal value is {max},minimal value is {min}");
        Console.ReadKey();
    }

    public void Decimal()
    {
        decimal max = decimal.MaxValue;
        decimal min = decimal.MinValue;
        decimal a = 1.0M;
        decimal b = 3.0M;
        decimal c = a / b;
        Console.WriteLine($"1.0M / 3.0M = {c}");
        Console.WriteLine($"The range of decimal is {max} to {min}");
        Console.ReadLine();
    }

// Challenge
    public void Challenge()
    {
        double Banjing = 2.5;
        double Area = Banjing * Banjing * Math.PI;
        Console.WriteLine($"Area = {Area}");
        Console.ReadKey();
    }
}

public class AccessFunctions
{
    public void Access()
    {
        YunSuan Yunsuan = new YunSuan();
        Yunsuan.ZhengShu();
        Yunsuan.ChufaheYushu();
        Yunsuan.MaxMinInt();
        // If overflow,then max will back to min value and +1-2 (+3)
        Yunsuan.Double();
        Yunsuan.Decimal();
        Yunsuan.Challenge();
    }
}

public class ProgramMain
{
    static void Main()
    {
        AccessFunctions access = new AccessFunctions();
        access.Access();
    }
}