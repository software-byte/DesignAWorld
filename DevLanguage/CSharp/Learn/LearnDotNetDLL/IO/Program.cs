using System;

namespace IO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 输出
            Console.WriteLine("请输入一个数字：");

            // 输入
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你输入了一个{0}", number);
            Console.WriteLine("你输入了一个" + number);
            Console.WriteLine($"你输入了一个{number}");
            
            Console.WriteLine("请输入一个字符串：");
            string inputString = Console.ReadLine();
            Console.WriteLine("您输入的字符串是：" + inputString);

            Console.WriteLine("按任意键退出程序...");
            Console.ReadKey();
        }
    }
}