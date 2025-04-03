using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NajibN.Sprint1.Task3.V14.Lib;
namespace Tyuiu.NajibN.Sprint1.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Нассер Нажиб | истнб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Нассер Нажиб             | истнб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            double x = 1;

            Console.WriteLine("Обратный порядок: " + x);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Число: " + ds.ReverseNumber(x));
            Console.ReadKey();
        }
    }
}
