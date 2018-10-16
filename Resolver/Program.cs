using System;
using System.Globalization;

namespace Resolver
{
    internal static class Program
    {
        private static void Main()
        {
            // Ввод данных уравнения - значения a, b и c
            // После ввода данных мы обрезаем лишние пробелы по краям методом Trim()
            // и преобразовываем тип string во double
            Console.Write("Введите значение a = ");
            var a = double.Parse(Console.ReadLine()?.Trim() ?? "0");

            Console.Write("Введите значение b = ");
            var b = double.Parse(Console.ReadLine()?.Trim() ?? "0");

            Console.Write("Введите значение c = ");
            var c = double.Parse(Console.ReadLine()?.Trim() ?? "0");

            // Вычисление дискриминанта
            var d = b * b - 4 * a * c;

            // При дискриминанте меньшим 0 - выводим ошибку
            if (d < 0)
            {
                Console.Write("Дискриминант d < 0. Решение квадратного уравнения невозможно.");
            }
            else
            {
                // Объявляем корни уравнения
                double x1, x2;

                if (d > 0)
                {
                    // Извлекаем корень из дискриминанта
                    var sqrtD = Math.Sqrt(d);

                    // Высчитываем корни уравнения
                    x1 = (-b + sqrtD) / (2 * a);
                    x2 = (-b - sqrtD) / (2 * a);
                }
                else
                {
                    // При дискриминанте равным 0 оба корня равны
                    x1 = x2 = (b / 2 * a);
                }

                // Выводим результат
                Console.WriteLine("d = " + d.ToString(CultureInfo.InvariantCulture) + " x1 = " +
                                  x1.ToString(CultureInfo.InvariantCulture) + " x2 = " +
                                  x2.ToString(CultureInfo.InvariantCulture));
            }

            // Ждем нажатия клавиши, чтобы завершить выполнение программы
            Console.ReadLine();
        }
    }
}