using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation2
    {
        private int A;
        private int B;

        public Сalculation2(int a, int b)
        {
            if (a >= b)
            {
                throw new ArgumentException("А должно быть меньше");
            }
            A = a;
            B = b;
        }

        public List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = B; i >= A; i--)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        public int GetCount()
        {
            return B - A + 1;
        }
    }
}
