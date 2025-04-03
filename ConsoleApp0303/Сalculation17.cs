using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation17
    {
        private int N;
        private double A;
        private double B;

        public Сalculation17(int n, double a, double b)
        {
            N = n;
            A = a;
            B = b;
        }

        public List<double> CalculateFunctionValues()
        {
            List<double> values = new List<double>();
            double H = (B - A) / (N - 1);
            for (int i = 0; i < N; i++)
            {
                double X = A + i * H;
                values.Add(1 - Math.Sin(X));
            }
            return values;
        }
    }
}
