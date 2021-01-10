/*
 * Question link: https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
 */

using System;
using System.Collections.Generic;

namespace Leetcode.Solutions
{
    class SmallerThanCurrent
    {
        public static void RunTest()
        {
            List<int[]> testcases = new List<int[]>();
            testcases.Add(Solution(new int[] { 8, 1, 2, 2, 3 }));
            testcases.Add(Solution(new int[] { 6, 5, 4, 8 }));
            testcases.Add(Solution(new int[] { 7, 7, 7, 7 }));

            foreach (var solution in testcases)
            {
                foreach(var answer in solution)
                {
                    Console.Write($"{answer}\t");
                }

                Console.WriteLine();
            }
        }

        private static int[] Solution(int[] nums)
        {
            int[] result = new int[nums.Length];
            int length = nums.Length;

            for (int i=0; i<length; i++)
            {
                for (int j=0; j<length; j++)
                {
                    if (nums[i] != nums[j] 
                        && nums[i] > nums[j])
                    {
                        result[i]++;
                    }
                }
            }

            return result;
        }
    }
}
