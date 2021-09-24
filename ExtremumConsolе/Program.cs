using System;

namespace First_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Func new_func = new Func();

           
            Console.WriteLine("\nПри интервале [-2;2]");
            Console.WriteLine("Точка минимума функции:x=" + new_func.GetExtremumMin(-2, 2, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + new_func.GetExtremumMax(-2, 2, 0.001));

            Console.WriteLine("\nПри интервале [-8;8]");
            Console.WriteLine("Точка минимума функции:x=" + new_func.GetExtremumMin(0, 8, 0.001));
            Console.WriteLine("Точка максимума функции:x=" + new_func.GetExtremumMax(0, 8, 0.001));

        }
    }
}
