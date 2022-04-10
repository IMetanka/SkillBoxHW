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
            Console.WriteLine("Введите целое число:");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine($"Четное число");
            }
            else
            {
                Console.WriteLine($"Нечетное число");
            }

        }
    }
}
