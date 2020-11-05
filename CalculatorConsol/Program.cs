using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conlculator
{
    class Program
    {

        static void Main(string[] args)
        {
            

            double a;
            double b;
            double res = 0;
            char oper;

            Console.Write("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nКакое действие:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.Write("\nВведите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                res = a + b;
            }

            else if (oper == '-')
            {
                res = a - b;
            }

            else if (oper == '*')
            {
                res = a * b;
            }

            else if (oper == '/')
            {
                if (b != 0)
                    res = a / b;
                else Console.WriteLine("Серьёзно мужик?");
                
            }
            else
            {
                Console.WriteLine("У нас тут учёный который открыл новое действие!");
            }

            Console.WriteLine("\nРезультат: вы недавно слезли с ветки", res);
            Console.ReadLine();
        }
    }
}