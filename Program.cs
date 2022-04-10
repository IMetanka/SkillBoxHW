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
            Console.WriteLine("Здравствуй, друг! Сколько у тебя карт?");
            int cards = int.Parse(Console.ReadLine());
            int cardssumm = 0;
            Console.WriteLine("Ого! Давай посчитаем очки! \nДля карт с числовым номиналом введите цифру (6-10). \nДля вальта укажите - J, для дамы - Q, для короля - K, для туза - T\n ");


            for (int i = 1; i <= cards; i++)
            {
                Console.Write($"Введите номинал карты номер {i}\n");
                string cardvalue = Console.ReadLine();
                int value;


                switch (cardvalue)

                {
                    case "6":
                        value = 6;
                        cardssumm = value + cardssumm;
                        break;
                    case "7":
                        value = 7;
                        cardssumm = value + cardssumm;
                        break;
                    case "8":
                        value = 8;
                        cardssumm = value + cardssumm;
                        break;
                    case "9":
                        value = 9;
                        cardssumm = value + cardssumm;
                        break;
                    case "10":
                        value = 10;
                        cardssumm = value + cardssumm;
                        break;
                    case "J":
                        value = 10;
                        cardssumm = value + cardssumm;
                        break;
                    case "Q":
                        value = 10;
                        cardssumm = value + cardssumm;
                        break;
                    case "K":
                        value = 10;
                        cardssumm = value + cardssumm;
                        break;
                    case "T":
                        value = 10;
                        cardssumm = value + cardssumm;
                        break;
                    default:
                        Console.WriteLine("\nВведите корректный номинал карты:\n");
                        i--;
                        break;

                }
                

            }

            Console.WriteLine($"Сумма карт на руках = {cardssumm}");
            Console.ReadKey();

        }
}
}
