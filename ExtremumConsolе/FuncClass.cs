using System;

namespace First_Task
{
    public class Func
    {
        const double golden_ret = 1.618; //золотое сечение
        String f = "y=(x+1)^3+5x^2";


        double CalcFunc(double x)
        {
            return x = Math.Pow(x + 1, 3) + 5 * (x * x);
        }
        public double GetExtremumMin(double a, double b, double e) //a и b интервал, е точность
        {

            double x = 0;
            while (Math.Abs(b - a) > e)
            {

                double x1 = b - ((b - a) / golden_ret);
                double x2 = a + ((b - a) / golden_ret);

                double y1 = CalcFunc(x1);
                double y2 = CalcFunc(x2);

                if (y1 >= y2) a = x1;
                else b = x2;

                if (Math.Abs(b - a) < e)
                {
                    x = (a + b) * 0.5;
                    break;
                }
            }
            return x;
        }

        public double GetExtremumMax(double a, double b, double e)
        {

            double x = 0;
            while (Math.Abs(b - a) > e)
            {

                double x1 = b - ((b - a) / golden_ret);
                double x2 = a + ((b - a) / golden_ret);

                double y1 = CalcFunc(x1);
                double y2 = CalcFunc(x2);

                if (y1 <= y2) a = x1;
                else b = x2;

                if (Math.Abs(b - a) < e)
                {
                    x = (a + b) * 0.5;
                    break;
                }
            }
            return x;
        }

        public String ToString()
        {
            return f;
        }
    }
}
