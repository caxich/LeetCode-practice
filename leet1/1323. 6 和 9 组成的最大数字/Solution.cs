using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1323._6_和_9_组成的最大数字
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var s = num.ToString();
            if (!s.Any(x => x != '9'))
                return num;
            var list = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                var f = string.Empty;
                var e = string.Empty;
                if (s[i] == '6')
                {
                    if (i > 0)
                    {
                        f = s.Substring(0, i);
                    }
                    if (i + 1 < s.Length)
                    {
                        e = s.Substring(i + 1, s.Length - i - 1);
                    }
                    list.Add(int.Parse((f + "9" + e).Trim()));
                    f = string.Empty;
                    e = string.Empty;
                }
                else
                {
                    if (i > 0)
                    {
                        f = s.Substring(0, i);
                    }
                    if (i + 1 < s.Length)
                    {
                        e = s.Substring(i + 1, s.Length - i - 1);
                    }
                    list.Add(int.Parse((f + "6" + e).Trim()));
                    f = string.Empty;
                    e = string.Empty;
                }
            }
            return list.OrderBy(x => x).LastOrDefault();
        }
    }
}
