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

            //定义一个学生类，分别有姓名，性别，年龄，语文，数学，英语成绩
            //Class1 myPerson = new Class1();
            //myPerson._name = "屎忽鬼";
            //myPerson._age = 109;
            //myPerson._gender = "屎忽鬼";

            //myPerson.CHLSS();
            //Console.ReadKey();

            Student zsStudent = new Student("张三","男",24,96,90,99);
            zsStudent.SayHello();

            Student xhStudent = new Student("小红", "不男不女", 30, 96, 90, 99);
            xhStudent.SayHello();
            Console.ReadKey();
        }
    }
}
