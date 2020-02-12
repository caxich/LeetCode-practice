using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._171._Excel表列序号
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            var alphas = s.ToCharArray();
            var result = 0;
            for (int i = 0; i < alphas.Length; i++)
            {
                if (i == 0)
                {
                    result = alphas[alphas.Length - 1 - i] - 'A' + 1;
                }
                else
                {
                    result += (int)Math.Pow(26, i) * (alphas[alphas.Length - 1 - i] - 'A' + 1);
                }
            }
            return result;
        }
    }
}
