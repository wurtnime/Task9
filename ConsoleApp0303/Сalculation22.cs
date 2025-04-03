using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation22
    {
        private double X;

        public Сalculation22(double x)
        {
            X = x;
        }

        public double CalculateFunction()
        {
            if (X > 0 && X < 3.14)
            {
                return Math.Sin(X);
            }
            else if (X >= -3.14 && X < 0)
            {
                return Math.Pow(X, 3);
            }
            else if (X < -2 * 3.14 || X > 2 * 3.14)
            {
                return Math.Pow(X, 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
