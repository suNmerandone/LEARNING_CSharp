using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        public int CalcDifferentIntegerCount(int inNum)
        {
            // input: 123
            // output: 6 (123, 213, 231, 132, 312, 321)

            string strNum = inNum.ToString();
            int digitCount = strNum.Length;

            // Step 1. Re-assemble combination of the string
            List<string> allCombinationStrList = RecursionString("", strNum, strNum.Length);

            // Step 2. Convert to integer and remove duplicate items base on the digit count
            //List<string> nonDupCombiStrList = allCombinationStrList.Distinct().Where(s => s.Length == digitCount).ToList();
            List<int> parseCombiStrToIntList = allCombinationStrList.Select(int.Parse).ToList();
            List<int> nonDupCombiIntList = parseCombiStrToIntList.Distinct().Where(n => Math.Floor(Math.Log10(n) + 1) == digitCount).ToList();

            return nonDupCombiIntList.Count();
        }

        public static List<string> RecursionString(string desStr, string surStr, int origSurLen)
        {
            List<string> resultStrsList = new List<string>();

            if (desStr.Length == origSurLen)
            {
                //System.Diagnostics.Debug.WriteLine("desStr = " + desStr);
                resultStrsList.Add(desStr);
            }
            else
            {
                for (int i = 0; i < surStr.Length; i++)
                {
                    string tempDes = new string(desStr);
                    string tempSur = new string(surStr);
                    resultStrsList.AddRange(RecursionString(tempDes + tempSur.ToCharArray()[i], tempSur.Remove(i, 1), origSurLen));
                }
            }

            return resultStrsList;
        }
    }
}
