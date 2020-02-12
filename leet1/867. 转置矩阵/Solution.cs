using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._867._转置矩阵
{
    public class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            var len = A[0].Length;
            var result = new int[len][];
            for (int j = 0; j < len; j++)
            {
                var temp = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    temp[i] = 0;
                }
                result[j] = temp;
            }
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    result[j][i] = A[i][j];
                }
            }
            return result;
        }
    }
}
