using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._999._车的可用捕获量
{
    public class Solution
    {
        public int NumRookCaptures(char[][] board)
        {
            var rx = 0;
            var ry = 0;
            var checkCount = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        rx = i;
                        ry = j;
                        break;
                    }
                }
            }
            for (int i = 1; i <= ry; i++)
            {
                if (board[rx][ry - i].Equals('B'))
                {
                    break;
                }
                else if (board[rx][ry - i].Equals('p'))
                {
                    checkCount++;
                    break;
                }
            }
            for (int i = ry + 1; i < board[rx].Length; i++)
            {
                if (board[rx][i].Equals('B'))
                {
                    break;
                }
                else if (board[rx][i].Equals('p'))
                {
                    checkCount++;
                    break;
                }
            }
            for (int i = 1; i < rx; i++)
            {
                if (board[rx - i][ry].Equals('B'))
                {
                    break;
                }
                else if (board[rx - i][ry].Equals('p'))
                {
                    checkCount++;
                    break;
                }
            }
            for (int i = rx + 1; i < board.Length; i++)
            {
                if (board[i][ry].Equals('B'))
                {
                    break;
                }
                else if (board[i][ry].Equals('p'))
                {
                    checkCount++;
                    break;
                }
            }
            return checkCount;
        }
    }
}
