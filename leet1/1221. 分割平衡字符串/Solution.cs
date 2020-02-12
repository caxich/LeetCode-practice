using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet1._1221._分割平衡字符串
{
    public class Solution
    {
        public int BalancedStringSplit(string s)
        {
            var q = new Queue<char>();
            foreach (var item in s)
            {
                q.Enqueue(item);
            }
            var result = 0;
            var temp = new char();
            var tempCount = 0;
            temp = q.Dequeue();
            while (q.Any())
            {
                var q1 = q.Dequeue();
                if (temp == q1)
                {
                    tempCount++;
                    continue;
                }
                else
                {                   
                    for (int i = 0; i < tempCount; i++)
                    {
                        if (q.Any())
                            q.Dequeue();
                        else
                            return result;
                    }
                    tempCount = 0;
                    result++;
                    if (q.Any())
                        temp = q.Dequeue();
                    else
                        return result;
                }
            }
            return result;
        }
    }
}
