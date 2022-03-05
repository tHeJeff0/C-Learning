using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public Student(string name,string gender,int age,double math,double chinese,double english)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Math = math;
            this.Chinese = chinese;
            this.English = english;
            this.Sum = math + chinese + english;
            this.Avg = this.Sum / 3;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value != "男" && value != "女")
                {
                    value = "不男不女？？？";
                }
                _gender = value;
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        private double _math;

        public double Math
        {
            get { return _math; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _math = value;
            }
        }

        private double _chinese;

        public double Chinese
        {
            get { return _chinese; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _chinese = value;
            }
        }

        private double _english;

        public double English
        {
            get { return _english; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _english = value;
            }
        }

        private double _sum;

        public double Sum
        {
            get { return _sum; }
            set
            {
                value = Chinese + English + Math;
                _sum = value;
            }
        }

        private double _avg;

        public double Avg
        {
            get { return _avg; }
            set
            {
                value = Sum / 3;
                _avg = value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine("大家好，我叫{0},今年{1}岁，是个{2}的，语文成绩是{3}，数学成绩是{4}，英语成绩是{5}，总分{6}，平均分{7}。", this.Name,this.Age,this.Gender,this.Chinese,this.Math,this.English,this.Sum,this.Avg);
            Console.ReadKey();
        }
        
    }
}
