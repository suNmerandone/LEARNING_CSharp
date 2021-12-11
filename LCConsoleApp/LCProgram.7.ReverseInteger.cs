using System;
using System.Collections.Generic;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        /*
         * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
         */

        public int Reverse(int x)
        {
            int result = 0;

            try
            {
                var numArray = x.ToString().ToCharArray();
                List<char> numList = new List<char>(numArray);

                bool isNegNum = (numList[0] == '-');
                if (isNegNum)
                {
                    numList.RemoveAt(0);
                }

                numList.Reverse();

                StringBuilder revStrNum = new StringBuilder();
                foreach (char ch in numList)
                {
                    revStrNum.Append(ch);
                }

                if (isNegNum)
                {
                    revStrNum.Insert(0, "-");
                }

                int.TryParse(revStrNum.ToString(), out result);
            }
            catch
            {
                //result = 0;
            }

            return result;
        }

        // The Runtime and Memory Usage is almost the same...
        //public int Reverse(int x)
        //{
        //    var sign = x < 0 ? -1 : 1;
        //    if ((x >= int.MaxValue || x <= int.MinValue))
        //        return 0;
        //    x = Math.Abs(x);
        //    long Reverse = 0;
        //    while ((x < int.MaxValue || x > int.MinValue) && x > 0)
        //    {
        //        int remainder = x % 10;
        //        Reverse = (Reverse * 10) + remainder;
        //        if (Reverse > int.MaxValue || x < int.MinValue)
        //        {
        //            Reverse = 0;
        //            break;
        //        }
        //        x = x / 10;
        //    }
        //    return (int)(Reverse * sign);
        //}
    }
}
