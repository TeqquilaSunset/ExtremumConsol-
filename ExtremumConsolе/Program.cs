using System;

namespace ExtremumConsolе
{
    class Program
    {
        static double CalcFunc(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * (x * x);
        }

        static void Main(string[] args)
        {
            GoldenSection gs = new();
            Dichotomy dicht = new();


            Console.WriteLine("Метод золотого сечния:");
            Console.WriteLine("Интервал: [-2;2]");
            Console.WriteLine("Точка минимума функции:x=" + gs.ExtrMin(CalcFunc, -2, 2, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + gs.ExtrMax(CalcFunc, -2, 2, 0.001));
            Console.WriteLine("Интервал: [0;8]");
            Console.WriteLine("Точка минимума функции:x=" + gs.ExtrMin(CalcFunc, 0, 8, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + gs.ExtrMax(CalcFunc, 0, 8, 0.001));


            Console.WriteLine("\nМетод дехотомии:");
            Console.WriteLine("Интервал: [-2;2]");
            Console.WriteLine("Точка минимума функции:x=" + dicht.ExtrMin(CalcFunc, -2, 2, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + dicht.ExtrMax(CalcFunc, -2, 2, 0.001));
            Console.WriteLine("Интервал: [0;8]");
            Console.WriteLine("Точка минимума функции:x=" + dicht.ExtrMin(CalcFunc, 0, 8, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + dicht.ExtrMax(CalcFunc, 0, 8, 0.001));


            Console.ReadKey();
        }
    }
}
