using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._657._机器人能否返回原点
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            if (moves.Count(x => x.Equals('L')) == moves.Count(x => x.Equals('R'))
                && moves.Count(x => x.Equals('U')) == moves.Count(x => x.Equals('D')))
            {
                return true;
            }
            else
                return false;
        }
    }
}
