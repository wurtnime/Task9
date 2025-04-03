using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation3
    {
        private double A;
        private int N;

        public Сalculation3(double a, int n)
        {
            A = a;
            N = n;
        }

        public double CalculatePower()
        {
            return Math.Pow(A, N);
        }
    }
}