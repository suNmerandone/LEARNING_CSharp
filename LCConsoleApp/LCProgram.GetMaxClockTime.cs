using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        public string GetMaxClockTime(int inNum)
        {
            // 請回傳 最大的時鐘數字，例如:1234 -> 要回傳23:41，若數字不合理也要偵測。
            // 先考慮僅傳入 4 位數字，若有三位數的再另作 enhancements

            string result = string.Empty;

            // Step 1. Re-assemble combination of the string
            string strNum = inNum.ToString();
            List<string> allCombinationStrList = RecursionString("", strNum, strNum.Length);
            allCombinationStrList = allCombinationStrList.OrderBy(x => x).ToList();

            // Step 2. Split all string into hour and minute parts
            List<string> allHourMinuteStrList = new List<string>();
            try
            {
                foreach (var combineStr in allCombinationStrList)
                {
                    bool isHourValid = false;
                    bool isMinuteValid = false;

                    if (!string.IsNullOrEmpty(combineStr))
                    {
                        int parseHour = int.Parse(combineStr.Substring(0, 2));
                        if (0 <= parseHour && parseHour < 24)
                        {
                            isHourValid = true;
                        }

                        int parseMinute = int.Parse(combineStr.Substring(2, 2));
                        if (0 <= parseMinute && parseMinute < 60)
                        {
                            isMinuteValid = true;
                        }

                        if (isHourValid && isMinuteValid)
                        {
                            allHourMinuteStrList.Add(parseHour + ":" + parseMinute);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("The input number is invalid...\n" + ex);
            }

            // Step 2-1. 假設 input number 不會有無法組合成合理四位數時鐘的狀況，以數字 8796 為例，這樣就還要考慮所有如 08, 07, 09, 06 的單位數組合...

            // Step 3. Finding the max one
            result = allHourMinuteStrList.Last();

            return result;
        }
    }
}
