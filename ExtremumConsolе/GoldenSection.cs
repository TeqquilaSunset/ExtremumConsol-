using System;

namespace First_Task
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
        public double GetExtremumMin(Func<double, double> func, double a, double b, double e)
        {

            double x1 = 0;
            double x2 = 0;

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
                    x1 = (a + b) * 0.5;
                    break;
                }
            }
            return x1;
        }

        /// <summary>
        /// Метод поиска максимума фунции на заданном отрезке
        /// </summary>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="e">Точность.</param>
        /// <returns></returns>
        public double GetExtremumMax(Func<double, double> func, double a, double b, double e)
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
                    x1 = (a + b) * 0.5;
                    break;
                }
            }
            return x1;
        }


    }
}
