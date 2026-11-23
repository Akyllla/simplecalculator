
using System;

namespace GitHubCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("=== КАЛЬКУЛЯТОР ===");

            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("+ Сложение");
            Console.WriteLine("- Вычитание");
            Console.WriteLine("* Умножение");
            Console.WriteLine("/ Деление");

            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = calculator.Add(a, b);
                    break;
                case "-":
                    result = calculator.Subtract(a, b);
                    break;
                case "*":
                    result = calculator.Multiply(a, b);
                    break;
                case "/":
                    result = calculator.Divide(a, b);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    return;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
