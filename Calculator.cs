
using System;

namespace GitHubCalculator
{
    public class Calculator
    {
        // Сложение
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Вычитание
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Умножение
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Деление
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException(
                    "На ноль делить нельзя!");

            return a / b;
        }
    }
}
