using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1217._玩筹码
{
    public class Solution
    {
        public int MinCostToMoveChips(int[] chips)
        {
            var a = chips.Where(x => x % 2 == 0).Count();
            var b = chips.Where(x => x % 2 != 0).Count();
            return Math.Min(a, b);
        }
    }
}
