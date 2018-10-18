using System;

namespace Resolver
{
  public static class Util
  {
    private static double CountDiscriminant(double a, double b, double c) => b * b - 4 * a * c;

    public static double[] ResolveEquation(double a, double b, double c)
    {
      // Вычисление дискриминанта
      var discriminant = CountDiscriminant(a, b, c);

      // При дискриминанте меньшим 0 - выводим ошибку
      if (discriminant < 0)
      {
        throw new Exception("Дискриминант d < 0. Решение квадратного уравнения невозможно.");
      }

      if (discriminant > 0)
      {
        // Извлекаем корень из дискриминанта
        var sqrtD = Math.Sqrt(discriminant);

        // Высчитываем корни уравнения
        return new[]
        {
          (-b + sqrtD) / (2 * a),
          (-b - sqrtD) / (2 * a)
        };
      }

      // При дискриминанте равным 0 оба корня равны
      return new[]
      {
        b / 2 * a
      };
    }
  }
}