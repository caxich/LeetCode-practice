using leet1.解压缩编码;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leet1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 2, 2, 3, 3, 3, 3, 4, 4, 4, 1, 2, 3 };
            int[] ssss = { 1, 0, 1 };
            int[] s1 = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            //s = s.Reverse().ToArray();
            char[] c = ("hello").ToCharArray();
            string[] sa = { "5", "2", "C", "D", "+" };
            //int[][] ss = { new int[]{ 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };
            string[] ss = { "gin", "zen", "gig", "msg" };
            Console.WriteLine(new leet1._136._只出现一次的数字.Solution().SingleNumber(s));
            Console.ReadKey();
        }
    }
}
