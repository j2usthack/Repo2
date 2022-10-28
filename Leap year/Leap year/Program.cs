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
            int year = Convert.ToInt32(Console.ReadLine()); //конвертируем число в строку
            Console.WriteLine($"{year} г. {(IsLeapYear(year) ? "високосный" : "не високосный")}");//первая часть кода выведет переменную, вторая часть кода применит к этой переменной метод "IsLeapYear".
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
