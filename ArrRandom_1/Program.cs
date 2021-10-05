using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrRandom_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 15;
            int max,min;
            int[] array = new int[k];
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(0,50);
            }
            Console.WriteLine("Массив");
            max = array[0]; min = array[0];
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0,3} ", array[i]);
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент = {0}", max);
            Console.WriteLine("Минимальный элемент = {0}", min);
            Console.ReadKey();
        }
    }
}
