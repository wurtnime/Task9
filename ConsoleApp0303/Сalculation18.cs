using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation18
    {
        private double D;

        public Сalculation18(double d)
        {
            D = d;
        }

        public (int K, double AKMinus1, double AK) FindConvergence()
        {
            double AKMinus1 = 2;
            double AK = 2 + 1 / AKMinus1;
            int K = 2;
            while (Math.Abs(AK - AKMinus1) >= D)
            {
                AKMinus1 = AK;
                AK = 2 + 1 / AKMinus1;
                K++;
            }
            return (K, AKMinus1, AK);
        }
    }
}
