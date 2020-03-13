using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2_lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("数组的最大值为：" + Max(res));
            Console.WriteLine("数组的最小值为：" + Min(res));
            Console.WriteLine("数组的平均值为：" + Average(res));
            Console.WriteLine("数组的和为：" + Sum(res));
            Console.ReadKey();
        }
        static int Max(int [] a)
        {
            int max = a[0];
            foreach(int num in a)
            {
                if (max < num)
                    max = num;
            }
            return max;
        }

        static int Min(int [] a)
        {
            int min = a[0];
            foreach(int num in a)
            {
                if (min > num)
                    min = num;
            }
            return min;
        }

        static int Average(int []a)
        {
            int average=0, length=0;
            foreach(int num in a)
            {
                length++;
                average += num;
            }
            average /= length;
            return average;
        }

        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int num in a)
            {
                sum += num;
            }
            return sum;
        }
    }
}
