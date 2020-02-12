using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._461._汉明距离
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            var xs = new StringBuilder();
            var ys = new StringBuilder();
            while (x / 2 >= 0)
            {
                xs.Append(x % 2);
                x = x / 2;
                if (x <= 0)
                    break;
            }
            while (y / 2 >= 0)
            {
                ys.Append(y % 2);
                y = y / 2;
                if (y <= 0)
                    break;
            }

            if (xs.Length <= ys.Length)
            {
                var len = ys.Length - xs.Length;
                for (int i = 0; i < len; i++)
                {
                    xs.Append("0");
                }
            }
            else
            {
                var len = xs.Length - ys.Length;
                for (int i = 0; i < len; i++)
                {
                    ys.Append("0");
                }
            }

            var result = 0;
            for (int i = 0; i < Math.Min(xs.Length, ys.Length); i++)
            {
                if (xs[i] != ys[i])
                    result++;
            }
            return result;
        }
    }
}
