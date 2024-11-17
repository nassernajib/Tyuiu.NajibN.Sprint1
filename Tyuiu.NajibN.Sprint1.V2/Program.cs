using Tyuiu.NajibN.Sprint1.Task0.V2.Lib;
namespace Tyuiu.NajibN.Sprint1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |NasserN | Истнб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил:нассер Нажиб | Истнб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  вычисляет результат по формуле 10/(2+3)  и печатает результат на экране *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService dataService = new DataService();

            // Calculate the result
            double result = dataService.Calculate();

            // Print the result to the console
            Console.WriteLine($"The result of the expression is: {result}");

            // Wait for a key press before closing
            Console.ReadKey();
        }
    }
}
