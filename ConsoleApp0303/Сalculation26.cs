using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0303
{
    class Сalculation26
    {
        private int Number;

        public Сalculation26(int number)
        {
            Number = number;
        }

        public bool IsPalindrome()
        {
            string str = Number.ToString();
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
