using NUnit.Framework;
using System.Collections.Generic;

namespace Task2
{
    class Solution
    {
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string currentLine = string.Empty;
            int longestCall = 0;
            System.Collections.Generic.Dictionary<int, int> costs = new System.Collections.Generic.Dictionary<int, int>();
            int totalCost = 0;
            string[] timesAndPhones = S.Split(',', '\n');
            for (int index = 0; index < (timesAndPhones.Length / 2); index++)
            {
                int currentCost = 0;
                string[] timeComponents = timesAndPhones[index * 2].Split(':');
                int seconds = System.Convert.ToInt32(timeComponents[0]) * 3600 +
                    System.Convert.ToInt32(timeComponents[1]) * 60 +
                    System.Convert.ToInt32(timeComponents[2]);
                if (seconds < 5 * 60)
                    currentCost = seconds * 3;
                else if (seconds == (5 * 60))
                    currentCost = 5 * 150;
                else
                    currentCost = ((seconds % 5) + 5) * 150;
                totalCost += currentCost;
                // save cost
                costs.Add(seconds, currentCost);
                // set longest call
                if (longestCall < seconds)
                    longestCall = seconds;
            }
            return totalCost - costs[longestCall];
        }
    }

    [TestFixture()]
    public class Task2Tests
    {
       
        [Test()]
        public void Test2()
        {
            Solution instance = new Solution();
            string S = @"00:01:07,400-234-090
00:05:01,701 - 080 - 080
00:05:00,400 - 234 - 090";            
            int R = instance.solution(S);
            Assert.AreEqual(R, 900);                      
        }
       
    }


}
