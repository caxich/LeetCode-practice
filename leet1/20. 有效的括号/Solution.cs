using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet1
{
    /// <summary>
    /// 递归方式，时长超时
    /// </summary>
    public class Solution
    {
        public bool IsValid(string s)
        {
            var left = new List<BracketItem>
            {
                new BracketItem(0,'('),
                new BracketItem(1,'{'),
                new BracketItem(2,'['),
            };
            var right = new List<BracketItem>
            {
                new BracketItem(0,')'),
                new BracketItem(1,'}'),
                new BracketItem(2,']'),
            };
            var inputs = s.ToCharArray();
            if (string.IsNullOrWhiteSpace(s))
                return true;
            var len = inputs.Length;
            if ((len % 2) != 0)
                return false;
            var brackets = new List<BracketItem>();
            for (int i = 0; i < inputs.Length; i++)
            {
                brackets.Add(new BracketItem(i, inputs[i]));
            }

            return EmptyBlank(brackets, brackets.Count, left, right);
        }

        public class BracketItem
        {
            public BracketItem(int index, char verb)
            {
                Index = index;
                Verb = verb;
            }
            public int Index { get; set; }
            public char Verb { get; set; }
        }

        public static bool EmptyBlank(List<BracketItem> dicts, int len, List<BracketItem> left, List<BracketItem> right)
        {
            var leftChar = dicts.LastOrDefault(x => left.Select(y => y.Verb).Contains(x.Verb));
            if (leftChar != null)
            {
                var leftIndex = left.FirstOrDefault(x => x.Verb == leftChar.Verb);
                if (dicts.IndexOf(leftChar) + 1 < len && leftIndex != null &&
                    leftIndex.Index < right.Count)
                {
                    var rightChar = dicts[dicts.IndexOf(leftChar) + 1];
                    var rightIndex = right[leftIndex.Index];
                    if (rightChar != null && rightIndex != null && rightChar.Verb == rightIndex.Verb)
                    {
                        dicts.Remove(leftChar);
                        dicts.Remove(rightChar);
                        if (!dicts.Any())
                            return true;
                        return EmptyBlank(dicts, dicts.Count, left, right);
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            else
                return false;
        }
    }
}
