/*
 * Question link: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
 */

using System;
using System.Collections.Generic;

namespace Leetcode.Solutions
{
    class GreatestNumberCandies
    {
        public static void RunTest()
        {
            IList<bool>[] TEST_CASES = new IList<bool>[]
            {
                Solution(new int[] { 2,3,5,1,3}, 3),
                Solution(new int[] { 4,2,1,1,2}, 1),
                Solution(new int[] { 12,1,12}, 10)
            };

            foreach(var answer in TEST_CASES)
            {
                foreach (var e in answer)
                {
                    Console.Write($"{e}\t");
                }
                Console.WriteLine();
            }
        }

        private static IList<bool> Solution(int[] candies, int extraCandies)
        {
            if (candies.Length < 2 || candies.Length > 100) return new List<bool>();
            if (extraCandies < 1 || extraCandies > 50) return new List<bool>();

            IList<bool> result = new List<bool>();
            int greatest = 0;

            foreach(var count in candies)
            {
                if (count > greatest) greatest = count;
            }

            foreach(var count in candies)
            {
                result.Add(count + extraCandies >= greatest);
            }

            return result;
        }
    }
}
