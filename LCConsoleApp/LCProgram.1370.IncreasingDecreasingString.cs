using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCConsoleApp
{
    public partial class LCProgram
    {
        /*
            Given a string s. You should re-order the string using the following algorithm:

            1. Pick the smallest character from s and append it to the result.
            2. Pick the smallest character from s which is greater than the last appended character to the result and append it.
            3. Repeat step 2 until you cannot pick more characters.
            4. Pick the largest character from s and append it to the result.
            5. Pick the largest character from s which is smaller than the last appended character to the result and append it.
            6. Repeat step 5 until you cannot pick more characters.
            7. Repeat the steps from 1 to 6 until you pick all characters from s.
            In each step, If the smallest or the largest character appears more than once you can choose any occurrence and append it to the result.

            Return the result string after sorting s with this algorithm.
         */

        public string SortString(string s)
        {
            string sortedString = string.Empty;

            string preSortString = incSortString(s.ToLower());

            if (!string.IsNullOrEmpty(preSortString))
            {
                List<char> charList = preSortString.ToCharArray().ToList();
                char lastChar;

                bool isNeedsNextInc = true;
                bool isNeedsNextDec = true;
                while (isNeedsNextInc || isNeedsNextDec)
                {
                    // Increasing case
                    lastChar = (char)60;                    // Let start to compare with ASCII 60 ('a' = 61)
                    isNeedsNextInc = false;                 // Set to zero before start
                    for (int i = 0; i < charList.Count; i++)
                    {
                        if (charList[i] != '\0' && charList[i] > lastChar)
                        {
                            sortedString += charList[i];

                            lastChar = charList[i];
                            charList[i] = '\0';

                            isNeedsNextInc = true;
                        }
                    }

                    // Decreasing case
                    lastChar = (char)123;                   // Let start to compare with ASCII 123 ('z' = 122)
                    isNeedsNextDec = false;                 // Set to zero before start
                    for (int i = charList.Count - 1; i > 0; i--)
                    {
                        if (charList[i] != '\0' && charList[i] < lastChar)
                        {
                            sortedString += charList[i];

                            lastChar = charList[i];
                            charList[i] = '\0';

                            isNeedsNextDec = true;
                        }
                    }
                }
            }

            return sortedString;
        }

        private string incSortString(string input)
        {
            char[] chars = input.ToArray();
            Array.Sort(chars);

            return new string(chars);
        }

        #region " POC "
        //private char pickOutNonDupSmallestChar(string input, char dupChar, out string output)
        //{
        //    output = input;

        //    char retChar = '\0';

        //    if (!string.IsNullOrEmpty(input))
        //    {
        //        char[] charArray = input.ToCharArray();
        //        List<char> charList = charArray.ToList();

        //        retChar = charList.Min();     // It is not good...
        //    }

        //    if (retChar != '\0' && retChar != dupChar)
        //    {
        //        int rmIdx = output.IndexOf(retChar);
        //        output = output.Remove(rmIdx, 1);
        //    }
        //    else
        //    {
        //        retChar = '\0';
        //    }

        //    return retChar;
        //}

        //private char pickOutNonDupLargestChar(string input, char dupChar, out string output)
        //{
        //    output = input;

        //    char retChar = '\0';

        //    if (!string.IsNullOrEmpty(input))
        //    {
        //        char[] charArray = input.ToCharArray();
        //        List<char> charList = charArray.ToList();

        //        retChar = charList.Max();     // It is not good...
        //    }

        //    if (retChar != '\0' && retChar != dupChar)
        //    {
        //        int rmIdx = output.LastIndexOf(retChar);
        //        output = output.Remove(rmIdx, 1);
        //    }
        //    else
        //    {
        //        retChar = '\0';
        //    }

        //    return retChar;
        //}
        #endregion

        // Simple char count solution
        //public string SortString(string s)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    int[] chars = new int[26];
        //    foreach (var c in s)
        //    {
        //        chars[c - 'a']++;
        //    }

        //    int count = 0;

        //    while (count < s.Length)
        //    {
        //        for (int i = 0; i < chars.Length; i++)
        //        {
        //            if (chars[i] > 0)
        //            {
        //                sb.Append((char)(i + 'a'));
        //                chars[i]--;
        //                count++;
        //            }
        //        }

        //        for (int i = chars.Length - 1; i >= 0; i--)
        //        {
        //            if (chars[i] > 0)
        //            {
        //                sb.Append((char)(i + 'a'));
        //                chars[i]--;
        //                count++;
        //            }
        //        }
        //    }

        //    string result = sb.ToString();
        //    return result;
        //}
    }
}
