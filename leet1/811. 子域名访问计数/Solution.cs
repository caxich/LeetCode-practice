using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._811._子域名访问计数
{
    public class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var dicts = new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
                dicts = GetCount(cpdomains[i], dicts);
            }
            var result = new List<string>();
            foreach (var item in dicts)
            {
                result.Add($"{item.Value} {item.Key}");
            }
            return result;
        }

        private Dictionary<string, int> GetCount(string s, Dictionary<string, int> tempDics)
        {
            var arr = s.Split(' ');
            var count = int.Parse(arr[0]);
            var names = arr[1].Split('.');
            if (names.Length > 2)
            {
                if (tempDics.ContainsKey(arr[1]))
                    tempDics[arr[1]] += count;
                else
                    tempDics.Add(arr[1], count);

                if (tempDics.ContainsKey($"{names[1]}.{names[2]}"))
                    tempDics[$"{names[1]}.{names[2]}"] += count;
                else
                    tempDics.Add($"{names[1]}.{names[2]}", count);

                if (tempDics.ContainsKey(names[2]))
                    tempDics[names[2]] += count;
                else
                    tempDics.Add(names[2], count);
            }
            else
            {
                if (tempDics.ContainsKey(arr[1]))
                    tempDics[arr[1]] += count;
                else
                    tempDics.Add(arr[1], count);

                if (tempDics.ContainsKey(names[1]))
                    tempDics[names[1]] += count;
                else
                    tempDics.Add(names[1], count);
            }
            return tempDics;
        }
    }
}
