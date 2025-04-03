using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation13
    {
        private double X;
        private int N;

        public Сalculation13(double x, int n)
        {
            X = x;
            N = n;
        }

        public double CalculateSum()
        {
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(X, 2 * i) / (2 * i);
            }
            return sum;
        }
    }
}
