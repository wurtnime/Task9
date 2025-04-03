using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation19
    {
        private double D;

        public Сalculation19(double d)
        {
            D = d;
        }

        public (int K, double AKMinus1, double AK) FindConvergence()
        {
            double AKMinus2 = 1;
            double AKMinus1 = 2;
            double AK = (AKMinus2 + AKMinus1) / 2;
            int K = 3;
            while (Math.Abs(AK - AKMinus1) >= D)
            {
                AKMinus2 = AKMinus1;
                AKMinus1 = AK;
                AK = (AKMinus2 + AKMinus1) / 2;
                K++;
            }
            return (K, AKMinus1, AK);
        }
    }
}
