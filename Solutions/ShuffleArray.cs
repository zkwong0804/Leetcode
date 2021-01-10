/*
 * Question link: https://leetcode.com/problems/shuffle-the-array/
 */

using System;
using System.Collections.Generic;
namespace Leetcode.Solutions
{
    class ShuffleArray
    {
        public static void RunTest()
        {
            List<int[]> TEST_CASE = new List<int[]>()
            {
                Solution(new int[] { 2,5,1,3,4,7}, 3),
                Solution(new int[] { 1,2,3,4,4,3,2,1}, 4),
                Solution(new int[] { 1,1,2,2}, 2),
            };
            foreach(var test in TEST_CASE)
            {
                foreach(var answer in test)
                {
                    Console.Write($"{answer}\t");
                }

                Console.WriteLine();
            }
        }

        private static int[] Solution(int[] nums, int n)
        {
            if (n < 1 || n > 500) return new int[] { };
            if (nums.Length != (2 * n)) return new int[] { };

            int[] result = new int[nums.Length];
            for (int i=0, j=n, counter=0; i<n; i++, j++, counter+=2)
            {
                result[counter] = nums[i];
                result[counter+1] = nums[j];
            }
            return result;
        }
    }
}
