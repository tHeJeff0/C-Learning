using System;

namespace __和__
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number = 10;
            number++;//number = number + 1
            Console.WriteLine(number);
            Console.ReadKey();*/

            /*int number = 10;
            int number1 = 10 + number++;//从左往右运算，number1=10+number，然后number=number+1
            Console.WriteLine(number1);
            int number2 = 10 + ++number;//相同原理，从左往右运算，number2 = 10+(number+1);
            Console.WriteLine(number2);*/

            int number = 10;
            int result = 10 + number--;
            Console.WriteLine(number);
            Console.WriteLine(result);
            Console.ReadKey();

            int number2 = 10;
            int result2 = 10 + --number2;
            Console.WriteLine(number2);
            Console.WriteLine(result2);
            Console.ReadKey();
            //和上面一样，--放在后面就是先运算再-，放在前面就是先-再运算；

            /*int a = 5;
            int b = a++ + ++a;
            Console.WriteLine(b);
            Console.ReadKey();

            int a1 = 5;
            int b1 = ++a1 + a1++;
            Console.WriteLine(b1);
            Console.ReadKey();*/

            int var1;
            int var2 = 5;
            int var3 = 10;
            var1 = var2++ * --var3;
            Console.WriteLine(var1);
        }
    }
}
