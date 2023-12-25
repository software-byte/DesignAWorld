using System; // Console
using System.IO; // Directory
using Util.Utils;
/*
 *
 * Dirctory 文件夹类
 *
 * DirctoryInfo 文件夹信息类
 *
 */

namespace DirectoryAndFIle.MyLearnScript
{
    public class LearnDirectory
    {
        private static SelectTestFunc[] testFuncs =
        {
            new SelectTestFunc("测试文件夹是否存在", TestExists),
        };

        private static void TestExists()
        {
            #region 检测文件夹是否存在

            // Directory
            string fileDir = @"F:\A学习\编程\飞思-拓晟\C#\Test\Excel";
            Console.WriteLine(Directory.Exists(fileDir)); // True

            // DirectoryInfo
            DirectoryInfo directoryInfo1 = new DirectoryInfo(fileDir);
            Console.WriteLine(directoryInfo1.Exists); // True

            #endregion
        }

        private void PrintTestFuncs()
        {
            for (int k = 1; k <= testFuncs.Length; k++)
            {
                Console.WriteLine($"{k}.{testFuncs[k - 1].Desc}");
            }
        }

        public void Test()
        {
            while (true)
            {
                PrintTestFuncs();
                Console.WriteLine("请选择一个进行测试, 输入<1的值退出");

                int index = Convert.ToInt32(Console.ReadLine());
                if (index < 1)
                {
                    Console.WriteLine("退出测试");
                    break;
                }

                if (index > testFuncs.Length)
                {
                    Console.WriteLine("索引超出了数组界限");
                }
                else
                {
                    testFuncs[index - 1].Func();
                }

                Console.WriteLine();
            }
        }
    }
}