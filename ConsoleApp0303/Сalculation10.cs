using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation10
    {
        private int N;

        public Сalculation10(int n)
        {
            N = n;
        }

        public double CalculateProduct()
        {
            double product = 2;
            for (int i = 2; i <= N; i++)
            {
                product *= 1.0 / i;
            }
            return product;
        }
    }
}
