using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation20
    {
        private int N;

        public Сalculation20(int n)
        {
            N = n;
        }

        public List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 10; i <= N; i++)
            {
                if (i % 5 == 0 && i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }
    }

}
