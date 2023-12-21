using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // бесконечном цикл
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    // Ввод первого числа
                    Console.WriteLine("Введите число 1: ");
                    firstValue = double.Parse(Console.ReadLine());

                    // Ввод второго числа
                    Console.WriteLine("Введите число 2: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch
                {
                    // Обработка ошибки при вводе чисел
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }

                // Выбор операции
                Console.WriteLine("Выберите операцию: '+', '-', '*', '/', '^', 'sqrt'");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "/")
                {
                    // Обработка деления на ноль
                    if (secondValue == 0)
                        Console.WriteLine("На 0 делить нельзя!");
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else if (action == "^")
                {
                    Console.WriteLine(Math.Pow(firstValue, secondValue));
                }
                else if (action == "sqrt")
                {
                    if (firstValue < 0)
                    {
                        // Обработка извлечения квадратного корня из отрицательного числа
                        Console.WriteLine("Квадратный корень из отрицательного числа не определен!");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine(Math.Sqrt(firstValue));
                }
                else
                {
                    // Обработка неизвестной операции
                    Console.WriteLine("Ошибка! Неизветное действие!");
                }
                Console.ReadLine();
            }
        }
    }
}
