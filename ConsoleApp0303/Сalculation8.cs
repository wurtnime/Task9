using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation8
    {
        private double A;

        public Сalculation8(double a)
        {
            A = a;
        }

        public (int N, double Sum) FindSmallestN()
        {
            double sum = 0;
            int N = 0;
            while (sum <= A)
            {
                N++;
                sum += 1.0 / N;
            }
            return (N, sum);
        }
    }
}
