using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int Sum = 0;
            int i = 0;
            Console.WriteLine("Введите 7 чисел массива");
            for(; i < 7;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическиое массива - {0}", Sum/i);
            Console.ReadKey();
        }
    }
}
