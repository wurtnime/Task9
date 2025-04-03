using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation4
    {
        private double A;
        private int N;

        public Сalculation4(double a, int n)
        {
            A = a;
            N = n;
        }

        public List<double> GetPowers()
        {
            List<double> powers = new List<double>();
            for (int i = 1; i <= N; i++)
            {
                powers.Add(Math.Pow(A, i));
            }
            return powers;
        }

    }
}