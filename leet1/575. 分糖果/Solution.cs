using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._575._分糖果
{
    public class Solution
    {
        public int DistributeCandies(int[] candies)
        {
            var uniqueA = candies.Distinct();
            if (uniqueA.Count() > candies.Length / 2)
                return candies.Length / 2;
            else
                return uniqueA.Count();
        }
    }
}
