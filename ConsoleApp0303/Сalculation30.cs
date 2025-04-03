using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation30
    {
        private int N;

        public Сalculation30(int n)
        {
            N = n;
        }

        public int FindSmallestDigit()
        {
            int minDigit = 9;
            int number = N;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
                number /= 10;
            }
            return minDigit;
        }
    }
}
