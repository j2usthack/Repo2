using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год для проверки на високосность: ");
            string userString = Console.ReadLine();
            int n, t;            
            n = Convert.ToInt32(userString);                     
            t = n % 4;
            if (t == 0)
                Console.Write("Год високосный");
            else
                Console.Write("Год НЕ високосный");
            
        }
    }
}
