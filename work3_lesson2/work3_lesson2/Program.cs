using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3_lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = EstablishArray(2, 200);
            GetResults(array);
            foreach(int num in array)
            {
                if (num != -1)
                    Console.WriteLine(num);
            }
            Console.ReadKey();
        }

        static int[] EstablishArray(int fore,int end)
        {
            int length = end - fore+1;
            int[] array = new int[length];
            for(int i=0;i<length;i++)
            {
                array[i] = fore+i;
            }
            return array;
        }

        static void GetResults(int []array)
        {
            int border = (int)Math.Sqrt(array.Max());
            for(int i=2;i<border;i++)
            {
                for(int j=0;j<array.Length;j++)
                {
                    if(array[j]!=-1&&array[j]%i==0&&i<array[j])
                    {
                        array[j] = -1;
                    }
                }
            }

        }


    }
}
