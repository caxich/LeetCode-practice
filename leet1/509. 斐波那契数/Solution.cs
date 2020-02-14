using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._509._斐波那契数
{
    public class Solution
    {
        public int Fib(int N)
        {
            var result = 0;
            if (N == 0)
                return 0;
            if (N == 1)
                return 1;
            var temp = 1;
            var second = 0;
            var i = 0;
            while (N >= i)
            {
                if (i == 0)
                {
                    second = 0;
                    result = 0;
                    temp = 0;
                }
                if (i == 1)
                {
                    second = 0;
                    result = 1;
                    temp = 0;
                }
                second = result;
                result += temp;
                temp = second;
                i++;
            }
            return result;
        }
    }
}
