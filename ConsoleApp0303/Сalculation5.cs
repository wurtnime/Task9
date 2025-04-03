using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Calculation5
    {
        private double A;
        private int N;

        public Calculation5(double a, int n)
        {
            A = a;
            N = n;
        }

        public double CalculateSum1()
        {
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(A, i);
            }
            return sum;
        }

        public double CalculateSum2()
        {
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(-A, i);
            }
            return sum;
        }
    }
}
