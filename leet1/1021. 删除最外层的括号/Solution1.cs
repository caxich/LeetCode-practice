using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1021._删除最外层的括号
{
    public class Solution1
    {
        public string RemoveOuterParentheses(string S)
        {
            var resultS = new StringBuilder();
            var resultList = new List<string>();
            var lcount = 0;
            var rcount = 0;
            foreach (var item in S)
            {
                resultS.Append(item);
                if (item.Equals('('))
                    lcount++;
                else
                    rcount++;
                if (lcount == rcount && lcount != 0 && rcount != 0)
                {
                    resultList.Add(resultS.ToString());
                    resultS.Clear();
                }
            }
            resultS.Clear();
            foreach (var item in resultList)
            {
                resultS.Append(item.Substring(1, item.Length - 2));
            }
            return resultS.ToString();
        }
    }
}
