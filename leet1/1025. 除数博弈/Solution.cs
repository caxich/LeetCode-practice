using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1025._除数博弈
{
    public class Solution
    {
        public bool DivisorGame(int N)
        {
            var i = 0;
            var count = 0;
            while (N > 0)
            {
                i++;
                if (N % i == 0)
                {
                    N -= i;
                    if (N > 0)
                    {
                        i = 0;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i > N)
                {
                    break;
                }
            }
            return count % 2 != 0 ? true : false;
        }
    }
}
