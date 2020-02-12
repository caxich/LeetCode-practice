using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._944._删列造序
{
    public class Solution
    {
        public int MinDeletionSize(string[] A)
        {
            var ar1 = 0;
            var len = A.Count();
            for (int i = 0; i < A[0].Length; i++)
            {
                for (int k = 0; k < len; k++)
                {
                    if (k + 1 < len)
                    {
                        if (A[k][i] > A[k + 1][i])
                        {
                            ar1++;
                            break;
                        }
                    }
                }
            }
            return ar1;
        }
    }
}
