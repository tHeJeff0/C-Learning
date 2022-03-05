using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int _age;

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

        public string _gender;

        public string Gender
        {
            get
            {
                if (_gender != "男" || _gender != "女")
                {
                    _gender = "不男不女？？？";
                }
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，性别{2}", this.Name, this.Age, this.Gender);
        }

    }
}
