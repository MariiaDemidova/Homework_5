using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное число");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            int i, j;
            int x = 1;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                        if (x == 1) 
                    {
                        array[i, j] = 2 % 2;
                        --x;
                    }
                    else
                    {
                        array[i, j] = 2 / 2;
                        ++x;
                    }
                    Console.Write("{0, 2}", array[i, j]);
                }
                Console.WriteLine();
                }
            Console.ReadKey();

        }
    }
}
