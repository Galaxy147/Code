using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // 输出换行
            // Console.Write() 输出不换行

            Console.ReadKey(); // 读取键盘输入的所有字符，返回字符串。按下回车键退出。一次读入一个字符
            // Console.Read(); 读取键盘输入的第一个字符，返回其对应的ASCII值。按下回车键退出。一次读入一个字符
            // Console.ReadLine(); 读取键盘输入的所有字符，返回字符串。按下回车键退出.一次读入一行
        }
    }
}