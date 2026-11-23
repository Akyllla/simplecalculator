
using System;
using System.Collections.Generic;

namespace GitHubCalculator
{
    public class History
    {
        private List<string> operations =
            new List<string>();

        // Добавление вычисления
        public void Add(double a, string operation,
                        double b, double result)
        {
            string record = a + " " + operation +
                            " " + b + " = " + result;

            operations.Add(record);
        }

        // Показ истории
        public void Show()
        {
            Console.WriteLine("\n=== ИСТОРИЯ ===");

            if (operations.Count == 0)
            {
                Console.WriteLine("История пуста");
                return;
            }

            foreach (string item in operations)
            {
                Console.WriteLine(item);
            }
        }

        // Очистка истории
        public void Clear()
        {
            operations.Clear();
            Console.WriteLine("История очищена!");
        }

        // Количество операций
        public int Count()
        {
            return operations.Count;
        }
    }
}
