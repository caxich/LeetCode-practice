using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._771.宝石与石头
{
    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            var js = J.ToCharArray();
            var ss = S.ToCharArray();
            var count = 0;
            foreach (var item in js)
            {
                var c = ss.Count(x => x == item);
                if (c > 0)
                    count += c;
            }
            return count;
        }
    }
}
