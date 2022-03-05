using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名");
            string uName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string uPass = Console.ReadLine();
            string msg = "";
            bool result = Program.Login(uName, uPass, out msg);
            Console.WriteLine(result);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        //提示输入用户名和密码，返回登陆结果
        public static bool Login(string name,string psd,out string msg)
        {
            bool result = true;
            if (name == "admin" && psd == "password")
            {
                msg = "登陆成功";
                return result;
            }
            else if (name != "admin" )
            {
                msg = "用户名错误";
                result = false;
                return result;
            }
            else if (psd != "password")
            {
                msg = "密码错误";
                result = false;
                return result;
            }
            else
            {
                msg = "写的什么几把";
                result = false;
                return result;
            }
        }
    }
}
