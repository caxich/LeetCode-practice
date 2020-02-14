using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._961._重复_N_次的元素
{
    public class Solution
    {
        public int RepeatedNTimes(int[] A)
        {
            var dicts = new Dictionary<int, int>();
            var temp = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (!dicts.ContainsKey(A[i]))
                {
                    dicts.Add(A[i], 1);
                }
                else
                {
                    temp = dicts[A[i]];
                    if (temp >= A.Length / 2)
                    {
                        return A[i];
                    }
                    else
                    {
                        dicts[A[i]] = ++temp;
                    }
                }
            }
            return dicts.Where(x => x.Value >= A.Length / 2).Any() ? dicts.Where(x => x.Value >= A.Length / 2).FirstOrDefault().Key : 0;
        }
    }
}
