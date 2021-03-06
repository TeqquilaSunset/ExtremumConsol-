using System;

namespace ExtremumConsolе
{
    public class GoldenSection
    {
        private const double FI = 1.618;

        /// <summary>
        /// Метод поиска минимума функции на заданном отрезке
        /// </summary>
        /// <param name="func">Задання функция.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="e">Точность.</param>
        /// <returns></returns>
        public double ExtrMin(Func<double, double> func, double a, double b, double e)
        {

            double x1;
            double x2;

            while (true)
            {
                x1 = b - ((b - a) / FI);
                x2 = a + ((b - a) / FI);

                if (func(x1) >= func(x2))
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < e)
                {
                    return  (a + b) * 0.5;
                }
            }
        }

        /// <summary>
        /// Метод поиска максимума фунции на заданном отрезке
        /// </summary>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="e">Точность.</param>
        /// <returns></returns>
        public double ExtrMax(Func<double, double> func, double a, double b, double e)
        {
            double x1 = 0;
            double x2 = 0;

            while (true)
            {
                x1 = b - ((b - a) / FI);
                x2 = a + ((b - a) / FI);

                if (func(x1) <= func(x2))
                    a = x1;
                else
                    b = x2;

                if (Math.Abs(b - a) < e)
                {
                    return (a + b) * 0.5;
                }
            }
            
        }


    }
}
