using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation25
    {
        private int N;

        public Сalculation25(int n)
        {
            N = n;
        }

        public int GetFirstDigit()
        {
            int number = N;
            while (number >= 10)
            {
                number /= 10;
            }
            return number;
        }

        public int GetSumOfDigits()
        {
            int sum = 0;
            int number = N;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
