using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "卡尔马龙", "迈克尔乔丹", "科比布莱恩特", "姚明" };
            string max = GetLongest(names);
            Console.WriteLine(max);
            Console.ReadKey();

            int[] numbers = { 1, 2, 7 };
            double avg = GetAvg(numbers);
            string s = avg.ToString("0.00");
            avg = Convert.ToDouble(s);

            Console.WriteLine(avg);
            Console.ReadKey();

        }

        public static string GetLongest(string[] names) 
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length < max.Length)
                {
                    max = names[i];
                }
            }
            return max;
                
        }
        
        public static double GetAvg(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }
    }
}
