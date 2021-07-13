using System;
using System.Collections.Generic;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        /*
         * Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
         */

        public int[] SortedSquares(int[] nums)
        {
            int[] retArray = new int[] { };

            List<int> numList = new List<int>();
            foreach (int num in nums)
            {
                int squNum = (int)Math.Pow(num, 2);
                numList.Add(squNum);
            }

            numList.Sort();
            retArray = numList.ToArray();
            return retArray;
        }

        /*
         * two-pointer solution
            Time: O(n) where n is the size of input array
            Space: O(n) due to the output array
        */
        //public int[] SortedSquares(int[] A)
        //{

        //    int[] res = new int[A.Length];
        //    int left = 0, right = A.Length - 1;

        //    for (int i = A.Length - 1; i >= 0; i--)
        //    {
        //        if (Math.Abs(A[left]) >= Math.Abs(A[right]))
        //        {
        //            res[i] = A[left] * A[left];
        //            left++;
        //        }
        //        else
        //        {
        //            res[i] = A[right] * A[right];
        //            right--;
        //        }
        //    }

        //    return res;
        //}
    }
}
