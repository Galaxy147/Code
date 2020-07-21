using System;
using System.Collections.Generic;

class Class1
{
    public static void Main()
    {
        var names = new List<string> {"Liu Zhuo", "Tuna", "22"};
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
        }
        names.Add("Nerd");
        names.Add("Stupid Kid");
        names.Remove("Tuna");
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
        }
    }
}