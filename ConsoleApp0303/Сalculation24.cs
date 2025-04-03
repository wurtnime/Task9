using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation24
    {
        private int N;

        public Сalculation24(int n)
        {
            N = n;
        }

        public int FindLargestDigit()
        {
            int maxDigit = 0;
            int number = N;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                number /= 10;
            }
            return maxDigit;
        }
    }
}
