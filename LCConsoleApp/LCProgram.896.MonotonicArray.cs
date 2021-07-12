using System;
using System.Collections.Generic;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        /*
         * An array is monotonic if it is either monotone increasing or monotone decreasing.
         * An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j].  An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].
         * Return true if and only if the given array nums is monotonic.
         */

        public bool IsMonotonic(int[] inArray)
        {
            bool isMonotonic = true;

            if (inArray == null)
            {
                return false;
            }
            else if (inArray.Length == 1)
            {
                return true;
            }

            bool isEqulNext = false;
            bool? isIncrease = null;

            int num_first = inArray[0];
            int num_last = inArray[inArray.Length - 1];
            if (num_first == num_last)
            {
                isEqulNext = true;
            }
            else if (num_first < num_last)
            {
                isIncrease = true;
            }
            else
            {
                isIncrease = false;
            }

            for (int i = 0; i < inArray.Length - 1; i++)
            {
                int num_x = inArray[i];
                int num_y = inArray[i + 1];

                if (isEqulNext == true && num_x != num_y)
                {
                    isMonotonic = false;
                }
                else if (isIncrease == true && num_x > num_y)
                {
                    isMonotonic = false;
                }
                else if (isIncrease == false && num_x < num_y)
                {
                    isMonotonic = false;
                }

                if (isMonotonic == false)
                {
                    break;
                }
            }

            return isMonotonic;
        }

        /* One Pass (Simple Variant)
         * To perform this check in one pass, we want to remember if it is monotone increasing or monotone decreasing.
         * It's monotone increasing if there aren't some adjacent values A[i], A[i+1] with A[i] > A[i+1], and similarly for monotone decreasing.
         * If it is either monotone increasing or monotone decreasing, then A is monotonic.
         * 
        public boolean isMonotonic(int[] A)
        {
            boolean increasing = true;
            boolean decreasing = true;
            for (int i = 0; i < A.length - 1; ++i)
            {
                if (A[i] > A[i + 1])
                    increasing = false;
                if (A[i] < A[i + 1])
                    decreasing = false;
            }

            return increasing || decreasing;
        }
        */
    }
}
