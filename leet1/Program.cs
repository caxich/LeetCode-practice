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
            int[] s = { 4, 9, 5 };
            int[] s1 = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            s = s.Reverse().ToArray();
            char[] c = ("hello").ToCharArray();
            string[] sa = { "5", "2", "C", "D", "+" };
            //int[][] ss = { new int[]{ 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };
            string[] ss = { "gin", "zen", "gig", "msg" };
            Console.WriteLine(new leet1._258._各位相加.Solution().AddDigits(38));
            Console.ReadKey();
        }
    }
}
