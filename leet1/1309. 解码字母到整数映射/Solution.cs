using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1309._解码字母到整数映射
{
    public class Solution
    {
        public string FreqAlphabets(string s)
        {
            var list = new List<string>();
            var i = 0;
            var sb = new StringBuilder();
            while (s.Length > i)
            {
                if (s[i] != '#')
                {
                    sb.Append(s[i]);
                }
                else if (s[i] != 0 && s[i] == '#')
                {
                    var f = sb.ToString().Substring(0, sb.Length - 2).ToCharArray();
                    var c = sb.ToString().Substring(sb.Length - 2, 2);
                    for (int j = 0; j < f.Length; j++)
                    {
                        list.Add(f[j].ToString());
                    }
                    if (!string.IsNullOrWhiteSpace(c))
                        list.Add(c);
                    sb.Clear();
                }
                i++;
            }
            if (sb.Length > 0)
            {
                for (int k = 0; k < sb.Length; k++)
                {
                    list.Add(sb[k].ToString());
                }
            }
            sb.Clear();

            for (int l = 0; l < list.Count; l++)
            {
                sb.Append(new System.Text.ASCIIEncoding().GetString(new byte[] { (byte)(int.Parse(list[l]) + 96) }));
            }

            return sb.ToString();
        }
    }
}
