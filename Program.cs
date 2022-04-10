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
            Console.WriteLine("Игра - Угадай число");
            Console.Write("Введите максимальное число диапазона: ");
            int maxValue = int.Parse(Console.ReadLine());
            if (maxValue <= 0)
                Console.Write("Введите число больше 0: ");

            int[] arr = new int[maxValue];
            int count = 0;
            string userNumber;
            int userNumber2;
            Random r = new Random();
            int iiNumber = r.Next(0, maxValue + 1);


            //for (int i = 0; i < arr.Length; i++)
            //{                                           //
            //    arr[i] = r.Next(maxValue + 1);        // Заполнение массива
            //    Console.Write($"{arr[i]} ");          // Вывод массива на экран
            //}

            Console.Write("Угадайте загаданное число из диапазона: ");

            while (true)
            {
                Console.Write("\nВведите число: ");
                count++;
                userNumber = Console.ReadLine();
                if (userNumber == "")
                {
                    Console.WriteLine($"Загаданное число {iiNumber}!");
                    Console.ReadKey();
                    break;
                }
               else
                { userNumber2 = Convert.ToInt32(userNumber);

                  if (userNumber2 < iiNumber)
                        {
                            Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
                        }
                  else if (userNumber2 > maxValue)
                        {
                            Console.WriteLine("Введенное число вышло из диапазона. Попробуйте еще раз");
                        }
                  else if (userNumber2 > iiNumber)
                        {
                            Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
                        }
                  else if (userNumber2 == iiNumber)
                        {
                            Console.WriteLine($"Поздравляю, число угадано!");
                            Console.ReadKey();
                            break;
                        }
                  

                    }






                }
            }
        }
    }





