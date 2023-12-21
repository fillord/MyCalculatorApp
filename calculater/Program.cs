using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // бесконечном цикл
            {
                Console.Clear();
                double firstValue, secondValue, result;
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

                switch (action)
                {
                    case "+":
                        result = firstValue + secondValue;
                        break;
                    case "-":
                        result = firstValue - secondValue;
                        break;
                    case "*":
                        result = firstValue * secondValue;
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            // Обработка деления на ноль
                            Console.WriteLine("На 0 делить нельзя!");
                            Console.ReadLine();
                            continue;
                        }
                        result = firstValue / secondValue;
                        break;
                    case "^":
                        result = Math.Pow(firstValue, secondValue);
                        break;
                    case "sqrt":
                        if (firstValue < 0)
                        {
                            // Обработка извлечения квадратного корня из отрицательного числа
                            Console.WriteLine("Квадратный корень из отрицательного числа не определен!");
                            Console.ReadLine();
                            continue;
                        }
                        result = Math.Sqrt(firstValue);
                        break;
                    default:
                        // Обработка неизвестной операции
                        Console.WriteLine("Ошибка! Неизвестное действие!");
                        Console.ReadLine();
                        continue;
                }
                // Вывод результата
                Console.WriteLine("Результат: " + result);
                Console.ReadLine();
            }
        }
    }
}