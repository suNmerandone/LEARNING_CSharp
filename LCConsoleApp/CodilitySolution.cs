using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;

namespace LCConsoleApp
{
    public class CodilitySolution
    {
        // Question 1. 各式附檔名以及其檔案大小之分類總計問題
        // 依照題目所給定的輸入格式進行字串處理，再將所有檔案分門別類、最後做加總
        // Enhancement: 可以將副檔名種類以 enum 進行管理、分割符號以 define 管理、可以再加強 string array 的長度防呆處理(而非如目前僅用 try-catch 處理)
        public string solution_fileAndSizeClassfication(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            string result = string.Empty;

            // Step 1. Set Data templetes
            List<int> allMusicSize = new List<int>();
            List<int> allImageSize = new List<int>();
            List<int> allMovieSize = new List<int>();
            List<int> allOtherSize = new List<int>();

            try
            {
                var allFiles = S.Split('\n');
                foreach (var file in allFiles)
                {
                    // Step 2. Set File/Size Data
                    var fileSizePair = file.Split(' ');

                    // Step 3. File Classification
                    var fileNames = fileSizePair[0].Split('.');
                    string extName = fileNames[fileNames.Length - 1];       // Get last index as file extension name
                    switch (extName)
                    {
                        case ("mp3"):
                        case ("aac"):
                        case ("flac"):
                            allMusicSize.Add(int.Parse(fileSizePair[1].Replace("b", "")));
                            break;

                        case ("jpg"):
                        case ("bmp"):
                        case ("gif"):
                            allImageSize.Add(int.Parse(fileSizePair[1].Replace("b", "")));
                            break;

                        case ("mp4"):
                        case ("avi"):
                        case ("mkv"):
                            allMovieSize.Add(int.Parse(fileSizePair[1].Replace("b", "")));
                            break;

                        default:
                            allOtherSize.Add(int.Parse(fileSizePair[1].Replace("b", "")));
                            break;
                    }

                }

                // Step 4. Size Consume
                result = "music " + allMusicSize.Sum() + 
                    "b\nimages " + allImageSize.Sum() + 
                    "b\nmovies " + allMovieSize.Sum() + 
                    "b\nother " + allOtherSize.Sum() + "b";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("The input string S is invalid...\n" + ex);
            }

            return result;
        }

        // Question 2. 城市旅行問題，在 N 個城市中，找出任兩個城市之間的旅程可以達到最高的吸引力分數(可以同一個城市重複旅行)
        // 小結論：在一維矩陣中所有排列組合中，依照需求(公式)計算找出最大分數
        // 先找出所有城市旅程的排列組合，再套用題目所給定的分數公式計算每一個組合的吸引力分數，最後再取最高者即可
        public int solution_highestAttractivenessCities(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            // Fomular = A[x] + A[y] + ((int)y - (int)x)

            int result = -1;

            // Step 1. Set Data Template
            List<KeyValuePair<int, int>> allCitiesCombination = new List<KeyValuePair<int, int>>();
            List<int> allAppealList = new List<int>();

            try
            {
                // Step 2. Find all Combination
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = 0; j < A.Length; j++)
                    {
                        allCitiesCombination.Add(new KeyValuePair<int, int>(i, j));
                    }
                }

                // Step 3. Get all Appeal Score
                foreach(var combine in allCitiesCombination)
                {
                    int score = solution_calTripAppealFomular(A[combine.Key], A[combine.Value], combine.Key, combine.Value);
                    allAppealList.Add(score);
                }

                // Step 4. Find the Highest one
                result = allAppealList.Max();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("The input array is invalid...\n" + ex);
            }

            return result;
        }

        public int solution_calTripAppealFomular(int a, int b, int x, int y)
        {
            return a + b + (y - x);
        }
    }
}
