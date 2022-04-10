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
            int i = 2;
            bool flag = Number % i == 0;

            if (Number < 2)
                Console.WriteLine($"Введите любое число, кроме 0 и 1.");
            if (Number == 2)
                Console.WriteLine($"Число простое.");

            while (i < Number)
            {
                if (Number % i == 0)

                {
                    i++;
                    flag = true;
                    Console.WriteLine($"Число не является простым.");
                    break;
                }
                else if (Number % i != 0 && i < Number)
                {
                    i++;
                    flag = false;
                   
                }

            }


            if (flag == false)
                Console.WriteLine($"Число простое.");


            Console.ReadKey();



            

        }
    }
}
