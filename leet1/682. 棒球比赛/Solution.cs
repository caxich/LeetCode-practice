using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._682._棒球比赛
{
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            var fr0 = 0;
            var fr1 = 0;
            var fr2 = 0;
            var result = 0;
            var plus = "+";
            var doubl = "D";
            var cler = "C";
            var temp = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == plus)
                {
                    temp = fr1 + fr2;
                    result += temp;
                    fr0 = fr1;
                    fr1 = fr2;
                    fr2 = temp;
                }
                else if (ops[i] == doubl)
                {
                    temp = fr2 + fr2;
                    result += temp;
                    fr0 = fr1;
                    fr1 = fr2;
                    fr2 = temp;
                }
                else if (ops[i] == cler)
                {
                    result -= fr2;
                    fr2 = fr1;
                    fr1 = fr0;
                    //fr0 = 0;
                }
                else
                {
                    result += int.Parse(ops[i]);
                    fr0 = fr1;
                    fr1 = fr2;
                    fr2 = int.Parse(ops[i]);
                }
            }
            return result;
        }
    }
}
