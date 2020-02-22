using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._682._棒球比赛
{
    public class Solution1
    {
        public int CalPoints(string[] ops)
        {
            var plus = "+";
            var doubl = "D";
            var cler = "C";
            var stack = new Stack<int>();
            var temp1 = 0;
            var temp2 = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i].Equals(plus))
                {
                    stack.TryPop(out temp2);
                    stack.TryPeek(out temp1);
                    stack.Push(temp2);
                    stack.Push(temp2 + temp1);
                }
                else if (ops[i].Equals(doubl))
                {
                    stack.TryPeek(out temp2);
                    stack.Push(temp2 + temp2);
                }
                else if (ops[i].Equals(cler))
                {
                    if (stack.Any())
                        stack.Pop();
                }
                else
                    stack.Push(int.Parse(ops[i]));
            }

            return stack.Sum();
        }
    }
}
