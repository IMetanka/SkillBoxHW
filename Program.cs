using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[row, col];

            Random r = new Random();

            for (int i = 0; i < row; i++)
            {
                //int sumRow = 0;
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(10);
                    //sumRow += arr2d[i, j];
                    Console.Write($"{arr2d[i, j]} ");
                }
                Console.WriteLine();

                //Console.WriteLine($"Сумма строки: {sumRow}");

            }

            int sum = 0; 
            foreach (int value in arr2d)
            {
                sum += value;
            }

            Console.WriteLine($"\nОбщая сумма всех элементов: {sum}");

            Console.WriteLine();





        }
    }
}





