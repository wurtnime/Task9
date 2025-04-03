using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation11
    {
        private double X;
        private int N;

        public Сalculation11(double x, int n)
        {
            X = x;
            N = n;
        }

        public double CalculateSum()
        {
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(X, i) / i;
            }
            return sum;
        }
    }
}
