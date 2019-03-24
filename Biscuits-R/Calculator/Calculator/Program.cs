using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string z = "";
            float a = 0;
            Random random = new Random();
            Console.WriteLine("进行四则运算");
            Console.WriteLine("请选择你要使用的运算:1.加法 2.减法 3.乘法 4.除法");
            Console.WriteLine("输入执行的题数");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                z = Console.ReadLine();
                int x = random.Next() % 1000;
                int y = random.Next() % 1000;
                switch (z)
                {
                    case "1":
                        a = x + y;
                        break;
                    case "2":
                        a = x - y;
                        break;
                    case "3":
                        a = x * y;
                        break;
                    case "4":
                        a = x / y;
                        break;
                }
                Console.WriteLine(a.ToString() + "=" + x + " " + y);
            }
        }
    }
}
