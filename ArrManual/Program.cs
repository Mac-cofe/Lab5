using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrManual
{
    class Program
    {
        static void Main(string[] args)
        {
            const int k = 7;
            float average = 0;
            int sum = 0;
            int[] array = new int[k];
            Console.WriteLine("В массиве 7 элементов. Введите значения элементов с клавиатуры");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Введите {0}-ый элемент", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0,3} ",array[i]);
                sum += array[i];
            }

            average = sum / 7;
            Console.WriteLine();
            Console.WriteLine("Сумма элементов = {0}", sum);
            Console.WriteLine("Среднее арифметическое = {0,3:f2}", average);
            Console.ReadKey();
        }
    }
}
