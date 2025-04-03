using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation23
    {
        private int N;

        public Сalculation23(int n)
        {
            N = n;
        }

        public double CalculateFactorial()
        {
            double factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public double CalculatePower()
        {
            return Math.Pow(2, N);
        }
    }
}
