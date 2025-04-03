using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation9
    {
        private int N;

        public Сalculation9(int n)
        {
            N = n;
        }

        public double CalculateFactorial()
        {
            double product = 1;
            for (int i = 1; i <= N; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
