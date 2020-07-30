using System;

namespace My_Third_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个数字");
            //string b = Console.ReadLine();
            //Console.ReadKey();
            //Console.WriteLine("请再输入一个数字");
            //string b2 = Console.ReadLine();
            //Console.ReadKey();
            //double a = Convert.ToDouble(b);//利用Convert.ToDouble把string变量b变成double变量a
            //double a2 = Convert.ToDouble(b2);//利用Convert.ToDouble把string变量b2变成double变量a2
            //double c = a + a2;
            //Console.WriteLine("{0}+{1}={2}",a,a2,c);
            //Console.ReadKey();

            Console.WriteLine("请输入您的名字");
            string name = Console.ReadLine();
            Console.WriteLine("请分别输入您的语文，数学，英语成绩");
            string chinese = Console.ReadLine();
            double chinese1 = Convert.ToDouble(chinese);//把string语文成绩转换成double
            string math = Console.ReadLine();
            double math1 = Convert.ToDouble(math);//把string数学成绩转换成double
            string english = Console.ReadLine();
            double english1 = Convert.ToDouble(english);//把string英语成绩转换成double
            double sum = chinese1 + math1 + english1;
            double avg = sum / 3;
            Console.WriteLine("{0}同学，您的总分是{1}，平均分是{2}", name, sum, avg);
            Console.ReadKey();

            Console.WriteLine("请输入一个数字");
            string strNumber = Console.ReadLine();
            double number = Convert.ToDouble(strNumber);
            Console.WriteLine(number * 2);
            Console.ReadKey();

        }
    }
}
