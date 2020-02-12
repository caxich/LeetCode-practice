using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._804._唯一摩尔斯密码词
{
    public class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char,string> mos = new Dictionary<char, string>(){ { 'a',".-" }, { 'b', "-..." }, { 'c', "-.-." }, { 'd', "-.." }, { 'e', "." }, { 'f', "..-." }, { 'g', "--." }, { 'h', "...." }, { 'i', ".." }, { 'j', ".---" }, { 'k', "-.-" }, { 'l', ".-.." }, { 'm', "--" }, { 'n', "-." }, { 'o', "---" }, { 'p', ".--." }, { 'q', "--.-" }, { 'r', ".-." }, { 's', "..." }, { 't', "-" }, { 'u', "..-" }, { 'v', "...-" }, { 'w', ".--" }, { 'x', "-..-" }, { 'y', "-.--" }, { 'z', "--.." } };

            var list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var wordsb = new StringBuilder();
                for (int j = 0; j < words[i].Length; j++)
                {
                    wordsb.Append(mos[words[i][j]]);
                }
                list.Add(wordsb.ToString());
                wordsb.Clear();
            }

            var resultList =  list.Distinct();
            return resultList.Count();
        }
    }
}
