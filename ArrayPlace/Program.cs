using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 20;
            int[] array = new int[k];
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(-50, 50);
            }
            Console.WriteLine("Массив");
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0,3} ", array[i]);
                if (i % 2 == 1 && array[i] % 2 == 1 && array[i] % 2 > 0) //так как индексы нумеруются от 0, то проверяем i % 2 == 1
                    count++;
            }
            Console.WriteLine();
            if (count == 0)
                Console.WriteLine("На четных местах расположены только четные элементы");
            else
                Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0}", count);
            Console.ReadKey();
        }
    }
}
