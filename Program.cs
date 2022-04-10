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
           
            int minValue = int.MaxValue;
           
            Console.Write("Введите длину последовательности: ");
            int sequence = int.Parse(Console.ReadLine());
            int[] arr1d = new int[sequence];    

            for (int i = 0; i < arr1d.Length; i++)
            {
                Console.Write($"Введите целое число № {i}\n");
                arr1d[i]= int.Parse(Console.ReadLine());
               
            }
            
            Console.WriteLine($"Вывод массива на экран:");

            for (int i = 0; i < arr1d.Length; i++)
                Console.WriteLine(arr1d[i]);



            for (int i = 0; i < arr1d.Length; i++)
            {

                if (minValue > arr1d[i])
                    minValue = arr1d[i];
                arr1d[i]++;
                 
            }

            Console.WriteLine($"Минимальное значение из массива {minValue} ");














        }
    }
}





