using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Input("Введите число месяца: ");
            int Month = (number);
        }
        static string GetName(int Month)
        {
            switch (Month)
            {
                case 1: case 2: case 12: return ("Зима");
                case 3: case 4: case 5: return ("Весна");
                case 6: case 7: case 8: return ("Лето");
                case 9: case 10: case 11: return ("Зима");
                default:
                    return ("Такого месяца нету");

            }
            }
            static int Input(string a)
            {
                Console.Write("a=");
                return int.Parse(Console.ReadLine());
            }


        
    }
}