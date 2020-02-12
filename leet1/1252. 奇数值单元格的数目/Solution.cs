using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1252._奇数值单元格的数目
{
    public class Solution
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            var lists = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                var list = new List<int>();
                for (int j = 0; j < m; j++)
                {
                    list.Add(0);
                }
                lists.Add(list);
            }
            for (int i = 0; i < indices.Length; i++)
            {
                if (indices[i][0] < n)
                {
                    for (int j = 0; j < m; j++)
                    {
                        lists[indices[i][0]][j] += 1;
                    }
                }
                if (indices[i][1] < m)
                {
                    for (int j = 0; j < n; j++)
                    {
                        lists[j][indices[i][1]] += 1;
                    }
                }
            }

            var result = 0;
            foreach (var item in lists)
            {
                result += item.Count(x => x % 2 != 0);
            }

            return result;
        }
    }
}
