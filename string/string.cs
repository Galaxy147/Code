using System;

namespace String
{
    // 字符串变量引用
    class StringMain
    {
        public void StrMain()
        {
            string firstman = "John";
            string secondman = "Bill";
            Console.WriteLine($"First Man:{firstman}");
            Console.WriteLine($"Second Man:{secondman}");
            Console.WriteLine($"My friends are {firstman} and {secondman}.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }

    // 字符串长度调取
    class StringLength
    {
        public void LengthMain()
        {
            string _Firstman = "John";
            string _Secondman = "Bill";
            Console.WriteLine($"The name {_Firstman} has {_Firstman.Length} letters");
            Console.WriteLine($"The name {_Secondman} has {_Secondman.Length} letters");
            Console.ReadKey();
            Console.WriteLine();
        }
    }

    // 字符串空格去除
    class TrimString
    {
        public void TrimStrMain()
        {
            string TrimStr = "      H E L L O     ";
            Console.WriteLine($"TrimStr :{TrimStr}");
            Console.WriteLine($"TrimStr Trimmed:{TrimStr.Trim()}");
            Console.WriteLine($"TrimStr Trimmed Start:{TrimStr.TrimStart()}");
            Console.WriteLine($"TrimStr Trimmed End:{TrimStr.TrimEnd()}");
            Console.ReadKey();  
            Console.WriteLine(); 
        }
    }

    // 以新的字符串替代变量中现存的字符串
    class ReplaceString
    {
        public void ReplaStrMain()
        {
            string ReplaStr = "Hello.This is Dotnet";
            Console.WriteLine($"Origin:{ReplaStr}");
            Console.WriteLine($"After Replace : {ReplaStr.Replace("Dotnet","Visual Studio")}");
            Console.ReadKey();
            Console.WriteLine();
        }
    }

    // 将字符串全部切换成大或小写
    class UpperLowerString
    {
        public void UpLowStrMain()
        {
            string UpLowStr = "hello,WORLD";
            Console.WriteLine(UpLowStr);
            Console.WriteLine($"After ToUpper : {UpLowStr.ToUpper()}"); 
            Console.WriteLine($"After ToUpper : {UpLowStr.ToLower()}");
            Console.ReadKey();
            Console.WriteLine();
        } 
    }

    // 查找字符串中的一部分（两种方法）
    class ContainWithStr
    {
        string str1 = "You say goodbye and I say hello";
        public void AccessProject()
        {
            Console.WriteLine($"str1:{str1}");
            Console.WriteLine($"Does str1 have goodbye? {str1.Contains("goodbye")}."); //查找goodbye
            Console.WriteLine($"Does str1 start with You? {str1.StartsWith("You")}."); //在开头查找You
            Console.WriteLine($"Does str1 end with You? {str1.EndsWith("say")}."); //在结尾查找say
            Console.ReadKey();
            Console.WriteLine();
        }
    }

    class ProgramMain
    {
        static void Main()
        {
            StringMain _String_Main = new StringMain();
            StringLength _String_Length = new StringLength();
            TrimString _Trim_String = new TrimString();
            ReplaceString _Replace_String = new ReplaceString();
            UpperLowerString _Upper_Lower_String = new UpperLowerString();
            ContainWithStr _Contain_With_String = new ContainWithStr();

            _String_Main.StrMain();
            _String_Length.LengthMain();
            _Trim_String.TrimStrMain();
            _Replace_String.ReplaStrMain();
            _Upper_Lower_String.UpLowStrMain();
            _Contain_With_String.AccessProject();
        }
    }
}