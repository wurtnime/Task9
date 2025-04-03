using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation28
    {
        public void PrintDifferenceOfSquares()
        {
            for (int i = 22; i <= 88; i++)
            {
                Console.WriteLine(i * i - (i - 1) * (i - 1));
            }
        }
    }
}
