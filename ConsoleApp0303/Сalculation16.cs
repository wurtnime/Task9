using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation16
    {
        private int N;
        private double A;
        private double B;

        public Сalculation16(int n, double a, double b)
        {
            N = n;
            A = a;
            B = b;
        }

        public double CalculateH()
        {
            return (B - A) / (N - 1);
        }

        public List<double> GetPartitionPoints()
        {
            List<double> points = new List<double>();
            double H = CalculateH();
            for (int i = 0; i < N; i++)
            {
                points.Add(A + i * H);
            }
            return points;
        }
    }
}
