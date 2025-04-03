using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation29
    {
        private double A;
        private int N;

        public Сalculation29(double a, int n)
        {
            A = a;
            N = n;
        }

        public List<double> CalculateDifferences()
        {
            List<double> differences = new List<double>();
            for (int i = 1; i <= N; i++)
            {
                differences.Add(A * A - i * i);
            }
            return differences;
        }
    }
}
