using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation14
    {
        private double X;
        private int N;

        public Сalculation14(double x, int n)
        {
            X = x;
            N = n;
        }

        public double CalculateSum()
        {
            double sum = X;
            for (int i = 2; i <= N; i++)
            {
                sum += Math.Pow(-1, i - 1) * Math.Pow(X, i) / i;
            }
            return sum;
        }
    }
}
