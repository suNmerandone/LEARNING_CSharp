using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            //Input: days = [1, 4, 6, 7, 8, 20], costs = [2, 7, 15] (1-day, 7-days, 30-days)
            //Output: 11 (+7, +2, +2)

            //Input: days = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31], costs = [2, 7, 15] (1-day, 7-days, 30-days)
            //Output: 17 (+15, +2)

            //! Dynamic Programming 的精神為計算直到最後一天 days[MAX] 的每一天累積花費

            // Sorting for just in case => 票價真的有可能沒高低排序，隨意 sorting 會導致後續計算錯誤票價
            //Array.Sort(days);
            //Array.Sort(costs);

            // Count each day spend
            int finalDay = days.Max();
            int[] totalDaysSpend = new int[finalDay + 1];
            for (int curDay = 1; curDay < totalDaysSpend.Count(); curDay++)
            {
                if (!days.Any(d => d == curDay))
                {
                    totalDaysSpend[curDay] = totalDaysSpend[curDay - 1];            // 如果非出遊日，則花費不需計算
                }
                else
                {
                    int todaySpend = totalDaysSpend[curDay - 1] + costs[0];                                     // 計算當天為出遊日最少為 1-day 的花費
                    todaySpend = Math.Min(todaySpend, totalDaysSpend[Math.Max(0, curDay - 7)] + costs[1]);      // 比較並計算當天為出遊日為 7-days 的花費
                    todaySpend = Math.Min(todaySpend, totalDaysSpend[Math.Max(0, curDay - 30)] + costs[2]);     // 比較並計算當天為出遊日為 30-days 的花費
                    totalDaysSpend[curDay] = todaySpend;
                }
            }

            return totalDaysSpend[finalDay];
        }
    }
}
