using System;

namespace First_Task
{
    class Program
    {
        static double CalcFunc(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * (x * x);
        }

        static void Main(string[] args)
        {
            GoldenSection new_func = new GoldenSection();
            Console.WriteLine("\nПри интервале [-2;2]");
            Console.WriteLine("Точка минимума функции:x=" + new_func.GetExtremumMin(CalcFunc, -2, 2, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + new_func.GetExtremumMax(CalcFunc, -2, 2, 0.001));
            Console.WriteLine("\nПри интервале [-8;8]");
            Console.WriteLine("Точка минимума функции:x=" + new_func.GetExtremumMin(CalcFunc, 0, 8, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + new_func.GetExtremumMax(CalcFunc, 0, 8, 0.001));

            

        }
    }
}
