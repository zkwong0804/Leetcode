/*
 * Question link: https://leetcode.com/problems/number-of-good-pairs/
 */

using System;
using System.Collections.Generic;

namespace Leetcode.Solutions
{
    class GoodPair
    {
        public static void RunTest()
        {
            Console.WriteLine(Solution(new int[] { 1, 2, 3, 1, 1, 3 }));
            Console.WriteLine(Solution(new int[] { 1, 1, 1, 1 }));
            Console.WriteLine(Solution(new int[] { 1, 2, 3 }));
        }

        private static int Solution(int[] nums)
        {
            if (nums.Length > 100 || nums.Length < 1) return 0;
            Dictionary<int, int> trackNum = new Dictionary<int, int>();
            int total = 0;
            foreach (var num in nums)
            {
                if (num < 1 || num > 100) return 0;
                if (trackNum.ContainsKey(num)) total += trackNum[num];
                else trackNum.Add(num, 0);
                trackNum[num]++;
            }

            return total;
        }
    }
}
