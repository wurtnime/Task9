using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation6
    {
        private int N;
        private int M;

        public Сalculation6(int n, int m)
        {
            N = n;
            M = m;
        }

        public (int K, int Value) FindSmallestK()
        {
            int K = 1;
            while (3 * K <= N)
            {
                K++;
            }
            return (K, 3 * K);
        }
    }
}
