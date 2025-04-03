using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation21
    {
        public List<int> GetSquares()
        {
            List<int> squares = new List<int>();
            for (int i = 11; i <= 99; i++)
            {
                squares.Add(i * i);
            }
            return squares;
        }
    }
}
