using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    class Program
    {
        private static void Main()
        {
            int year = Convert.ToInt32(Console.ReadLine()); //конвертирует строковое значение в 32-битное целочисленное значение со знаком.
            if (IsLeapYear(year)) //Если метод
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }
        }
        private static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 & year % 400 != 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
