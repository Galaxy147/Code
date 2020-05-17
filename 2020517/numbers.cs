using System;

namespace Numbers
{
    class ZhengShuYunSuan
    {
        public void ZhengShu()
        {
            int b = 20;
            int a = 10;
            int num1 = a + b;
            int num2 = a * b;
            int num3 = b / a;
            Console.WriteLine($"a = {a},b ={b}");
            Console.WriteLine($"a + b ={num1}");
            Console.WriteLine($"a ¡Á b ={num2}");
            Console.WriteLine($"b / a ={num3}");
            Console.ReadKey();
            Console.WriteLine();
        }
    }

    class ProgramMain
    {
        static void Main()
        {
            ZhengShuYunSuan zhengShuYunSuan = new ZhengShuYunSuan();
            zhengShuYunSuan.ZhengShu();
        }
    }
}