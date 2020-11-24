using System;
using System.Collections.Generic;
using System.Text;

namespace QueensAttackTheKing
{
    public class Solution
    {

        public static List<List<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {

            var queensthatCanAttack = new List<List<int>>();

            var leftQueenFound = false;
            var rightQueenFound = false;
            var upQueenFound = false;
            var downQueenFound = false;
            var dLeftUpQueenFound = false;
            var dRightUpQueenFound = false;
            var dLeftDownQueenFound = false;
            var dRightDownQueenFound = false;

            for (int nav = 1; nav < 8; nav++)
            {
                var left = new int[] { king[0], king[1] - nav };
                var right = new int[] { king[0], king[1] + nav };
                var up = new int[] { king[0] - nav, king[1] };
                var down = new int[] { king[0] + nav, king[1] };
                var dLeftUp = new int[] { king[0] - nav, king[1] - nav };
                var dRightUp = new int[] { king[0] - nav, king[1] + nav };
                var dLeftDown = new int[] { king[0] + nav, king[1] - nav };
                var dRightDown = new int[] { king[0] + nav, king[1] + nav };

                for (int i = 0; i < queens.Length; i++)
                {
                    var iQueen = queens[i];
                    if (!leftQueenFound && IsValidCell(left) && HasQueen(left, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        leftQueenFound = true;
                        continue;
                    }
                    if (!rightQueenFound && IsValidCell(right) && HasQueen(right, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        rightQueenFound = true;
                        continue;
                    }
                    if (!upQueenFound && IsValidCell(up) && HasQueen(up, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        upQueenFound = true;
                        continue;
                    }
                    if (!downQueenFound && IsValidCell(down) && HasQueen(down, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        downQueenFound = true;
                        continue;
                    }
                    if (!dLeftUpQueenFound && IsValidCell(dLeftUp) && HasQueen(dLeftUp, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        dLeftUpQueenFound = true;
                        continue;
                    }
                    if (!dRightUpQueenFound && IsValidCell(dRightUp) && HasQueen(dRightUp, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        dRightUpQueenFound = true;
                        continue;
                    }
                    if (!dLeftDownQueenFound && IsValidCell(dLeftDown) && HasQueen(dLeftDown, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        dLeftDownQueenFound = true;
                        continue;
                    }
                    if (!dRightDownQueenFound && IsValidCell(dRightDown) && HasQueen(dRightDown, iQueen))
                    {
                        queensthatCanAttack.Add(new List<int> { iQueen[0], iQueen[1] });
                        dRightDownQueenFound = true;
                    }
                }
            }

            return queensthatCanAttack;

        }


        public static bool IsValidCell(int[] cell)
        {
            return cell[0] >= 0 && cell[0] <= 7 && cell[1] >= 0 && cell[1] <= 7;
        }
        public static bool HasQueen(int[] cell, int[] queen)
        {
            return queen[0] == cell[0] && queen[1] == cell[1];
        }
    }
}
