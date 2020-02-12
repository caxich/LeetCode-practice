using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1266._访问所有点的最小时间
{
    public class Solution
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var result = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (i + 1 < points.Length)
                    result += Sub(points[i], points[i + 1]);
            }
            return result;
        }

        public int Sub(int[] x, int[] y)
        {
            int x1 = Math.Max(x[0], y[0]) - Math.Min(x[0], y[0]);
            int y1 = Math.Max(x[1], y[1]) - Math.Min(x[1], y[1]);

            if (x1 >= y1)
                return x1;
            else
                return y1;
        }
    }
}
