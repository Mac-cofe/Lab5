using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] control = new int[2 * n + 2];
            Console.WriteLine("Введите значения элементов массива");
            for (int i = 0; i < n; i++)         //заполнение массива
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("array[{0},{1}]=", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Сформирован массив");
            for (int i = 0; i < n; i++)         //вывод сформированного массива
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            int c = 0;
            for (int k = 0; k < n; k++) //подсчет сумм в столбцах, запись значений в доп.массив control
            {
                for (int i = 0; i < n; i++)
                {
                    control[c] += array[i, k];
                }
                c++;
            }
            c = n;
            for (int k = 0; k < n; k++) //подсчет сумм в строках, запись значений в доп.массив control
            {
                for (int i = 0; i < n; i++)
                {
                    control[c] += array[k, i];
                }
                c++;
            }
            int d1 = 0; //d1 - для суммы элементов главной диагонали 
            int d2 = 0;  //d2 - для суммы элементов побочной диагонали
            for (int i = 0; i < n; i++) //подсчет сумм элементов диагоналей
            {
                d1 += array[i, i];
                d2 += array[i, n - 1 - i];
            }
            control[2 * n] = d1; control[2 * n + 1] = d2; //запись значений диагоналей в доп.массив control

            Console.WriteLine();
            Console.WriteLine("В строке ниже отображаются последовательно суммы столбцов, строк и диагоналей");
            for (int i = 0; i < 2 * n + 2; i++)
            {
                Console.Write("{0} ", control[i]);  //вывод на экран доп.массива control (для проверки)
            }

            int a = control[0];
            int h = 0;
            for (int i = 0; i < 2 * n + 2; i++)
            {
                if (control[i] == a)
                    h++;                                        //проверяем на равенство все элементы доп.массива control
            }
            Console.WriteLine();
            if (h == 2 * n + 2)
                Console.WriteLine("Массив является магическим квадратом");
            else
                Console.WriteLine("Массив не является магическим квадратом");
            Console.ReadKey();
        }
    }
}
