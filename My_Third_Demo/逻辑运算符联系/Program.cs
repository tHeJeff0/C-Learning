using System;

namespace 逻辑运算符联系
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("请输入江泽民的数学成绩");
            string mathStr = Console.ReadLine();
            Console.WriteLine("请输入江泽民的语文成绩");
            string chineseStr = Console.ReadLine();
            double math = Convert.ToDouble(mathStr);
            double chinese = Convert.ToDouble(chineseStr);
            bool a1 = math > 90 && chinese > 90;
            Console.WriteLine(a1);
            Console.ReadKey();
            bool a2 = math > 90 || chinese > 90;
            Console.WriteLine(a2);
            Console.ReadKey();*/

            //判断闰年
            Console.WriteLine("请输入一个年份");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("那么{0}是闰年吗？",year);
            bool a = year % 4 == 0;
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
