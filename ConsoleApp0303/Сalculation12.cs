using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation12
    {
        private double X;
        private int N;

        public Сalculation12(double x, int n)
        {
            X = x;
            N = n;
        }

        public double CalculateSum()
        {
            double sum = X;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(X, 2 * i + 1) / (2 * i + 1);
            }
            return sum;
        }
    }
}
