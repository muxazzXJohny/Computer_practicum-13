﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_2_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Input=("Введите число месяца: ");
            int Month = (number);
        }
        static string GetName(int Month)
        {
            switch (Month)
            {
                case 1: return ("Январь");
                case 2: return ("Февраль");
                case 3: return ("Март");
                case 4: return ("Апрель");
                case 5: return ("Май");
                case 6: return ("Июнь");
                case 7: return ("Июль");
                case 8: return ("Август");
                case 9: return ("Сентябрь");
                case 10: return ("Октябрь");
                case 11: return ("Ноябрь");
                case 12: return ("Декабрь");
                default:
                    return ("Такого месяца нету");

            }
             int Input(string a)
            {
                Console.Write("a=");
                return int.Parse(Console.ReadLine());
            }


        }
    }
}
