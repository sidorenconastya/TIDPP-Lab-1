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

      // Try Catch для защиты от ошибок
      try
      {
        // Получить решение уравнения
        var result = Util.ResolveEquation(a, b, c);

        Console.WriteLine("The Equation solution is:");

        // В случае, если решение одно
        if (result.Length == 1)
        {
          Console.WriteLine("x = " + result[0].ToString(CultureInfo.InvariantCulture));
        }
        // В случае, если решений два
        else
        {
          for (var index = 0; index < result.Length; index++)
          {
            Console.WriteLine("x" + index + " = " + result[index].ToString(CultureInfo.InvariantCulture));
          }
        }
      }
      catch (Exception error)
      {
        Console.WriteLine(error.Message);
      }
      
      // Ждем нажатия клавиши, чтобы завершить выполнение программы
      Console.ReadLine();
    }
  }
}