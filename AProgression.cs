using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    internal class AProgression
    {
        // 1. Приватное поле для шага прогрессии
        private double step;

        // 2. Публичные свойства
        // First — автоматическое (валидация не нужна)
        public double First { get; set; }

        // Step — с валидацией (шаг не может быть 0)
        public double Step
        {
            get { return step; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Шаг прогрессии не может быть равен 0.");
                step = value;
            }
        }

        // 3. Конструктор — использует СВОЙСТВА, чтобы сработала валидация
        public AProgression(double first, double step)
        {
            First = first;
            Step = step;
        }

        // 4. Метод вычисления суммы первых n членов
        public double GetSum(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Количество членов n должно быть положительным (n > 0).");

            return n * (2 * First + (n - 1) * Step) / 2.0;
        }

        // 5. Метод вывода информации
        public void PrintInfo()
        {
            Console.WriteLine($"Арифметическая прогрессия: первый член = {First}, шаг = {Step}");
        }
    }
}