using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrRandom_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 10;
            int max, min;
            int[] array = new int[k];
            Random random = new Random();
            Console.WriteLine(" Исходный массив");
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,3} ", array[i]);
            }
            for (int i = 0; i < k/2-1; i++)
            {
                for (int q = i+1; q < k/2; q++)
                {
                    if (array[i]>array[q])
                    {
                        int w = array[i];
                        array[i] = array[q];
                        array[q] = w;
                    }
                }
            }
            for (int i = k/2; i < k-1; i++)
            {
                for (int q = i + 1; q < k; q++)
                {
                    if (array[i] < array[q])
                    {
                        int w = array[q];
                        array[q] = array[i];
                        array[i] = w;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Массив после сортировки");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0,3} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
