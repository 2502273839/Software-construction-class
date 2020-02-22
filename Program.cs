using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void getnum()
        {

        }

        static void Main(string[] args)
        {
            try
            {
                double num1 = 0;
                double num2 = 0;
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------\n");

                Console.WriteLine("请输入第一个数字：\n");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("请输入第二个数字：\n");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("选择一个操作：\n");
                Console.WriteLine("a--加法\n");
                Console.WriteLine("b--减法\n");
                Console.WriteLine("c--乘法\n");
                Console.WriteLine("d--除法\n");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"结果为：{num1}+{num2}=" + (num1 + num2));
                        break;
                    case "b":
                        Console.WriteLine($"结果为：{num1}-{num2}=" + (num1 - num2));
                        break;
                    case "c":
                        Console.WriteLine($"结果为：{num1}*{num2}=" + (num1 * num2));
                        break;
                    case "d":
                        while (num2 == 0)
                        {
                            Console.WriteLine("请重新输入一个不为零的除数/n");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"结果为：{num1}/{num2}=" + (num1 / num2));
                        break;
                }

            }catch(FormatException e)
            {
                Console.WriteLine(e.Data);
                Console.WriteLine("格式错误！");
            }catch(OverflowException e)
            {
                Console.WriteLine(e.Data);
                Console.WriteLine("溢出");
            }catch(Exception e)
            {
                Console.WriteLine(e.Data);
            }


            Console.ReadKey();
        }
    }
}
