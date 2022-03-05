using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个年份");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Program.Year(y);
            //Console.ReadKey();

            //Console.WriteLine("请输入一个数字");
            //string n = Console.ReadLine();
            //Program.Number(n);
            //Console.ReadKey();

            Console.WriteLine("当前数组的总和为");
            int[] numbers = { 5, 2, 3, 5, 645, 2234, 666, 12 };
            int sum = Sum(numbers);
            Console.WriteLine(sum);
            Console.ReadKey();

            Console.WriteLine("比较两个数字大小");
            try
            {
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                int max = Program.GetMax(n1, n2);
                Console.WriteLine(max + "比较大");
            }
            catch
            {
                Console.WriteLine("输入的东西比不了大小");
            }
            Console.ReadKey();

            Console.WriteLine("只能输入y或N");
            string input = Console.ReadLine();
            string output = Program.IsYN(input);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        //判断年份是否闰年
        public static bool Year(int y)
        {
            bool b = y % 400 == 0 || (y % 4 == 0 && y % 100 != 0);
            Console.WriteLine(b);
            return b;
        }

        //读取输入的整数，如果输入的是数字则返回，否则提示重新输入
        public static int Number(string input)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(input);
                    return n;
                }
                catch
                {
                    Console.WriteLine("无法转换成int,请重新输入");
                    input = Console.ReadLine();
                }
            }
        }
        //计算输入数组的和
        public static int Sum(int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length - 1; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        //查找两个整数中的最大值
        public static int GetMax(int n1,int n2)
        {
                int max = n1 > n2 ? n1 : n2;
                return max;
            
        }

        //只能输入Y或N
        public static string  IsYN(string input)
        {
            while (true)
            {
                if(input == "y" || input == "n" || input == "Y" || input == "N")
                {
                    string a = "可以看";
                    return a;
                }
                else
                {
                    Console.WriteLine("只能输入Y或者N");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
