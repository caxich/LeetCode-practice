using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._832._翻转图像
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i].Reverse().ToArray();
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = A[i][j] == 1 ? 0 : 1;
                }
            }
            return A;
        }
    }
}
