using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet1
{

    public class Solution2
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

            while (brackets.Any())
            {
                var leftChar = brackets.LastOrDefault(x => left.Select(y => y.Verb).Contains(x.Verb));
                if (leftChar != null)
                {
                    var leftIndex = left.FirstOrDefault(x => x.Verb == leftChar.Verb);
                    if (brackets.IndexOf(leftChar) + 1 < len && leftIndex != null &&
                        leftIndex.Index < right.Count)
                    {
                        var rightChar = brackets[brackets.IndexOf(leftChar) + 1];
                        var rightIndex = right[leftIndex.Index];
                        if (rightChar != null && rightIndex != null && rightChar.Verb == rightIndex.Verb)
                        {
                            brackets.Remove(leftChar);
                            brackets.Remove(rightChar);
                            len = brackets.Count;
                            if (!brackets.Any())
                                return true;
                            continue;
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
            return true;
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

    }
}
