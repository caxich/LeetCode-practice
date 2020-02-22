using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._118._杨辉三角
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<List<int>>();
            if (numRows == 1)
            {
                result.Add(new List<int>() { 1 });
            }
            else if (numRows == 2)
            {
                result.Add(new List<int>() { 1 });
                result.Add(new List<int>() { 1, 1 });
            }
            else if (numRows >= 3)
            {
                result.Add(new List<int>() { 1 });
                result.Add(new List<int>() { 1, 1 });
                for (int i = 2; i < numRows; i++)
                {
                    var temp = new List<int>();
                    temp.Add(1);
                    for (int j = 0; j < result[i-1].Count - 1; j++)
                    {
                        temp.Add(result[i - 1][j] + result[i - 1][j + 1]);
                    }
                    temp.Add(1);
                    result.Add(temp);
                }
            }
            return result.ToArray();
        }
    }
}
