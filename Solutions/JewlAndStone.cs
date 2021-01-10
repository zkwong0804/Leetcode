/*
 * Question link: https://leetcode.com/problems/jewels-and-stones/
 */

using System;
using System.Collections.Generic;


namespace Leetcode.Solutions
{
    class JewlAndStone
    {
        public static void RunTest()
        {
            (string J, string S)[] TESTCASES = new (string, string)[]
            {
                 ("aA", "aAAbbbb"),
                 ("z", "ZZ")
            };
            foreach(var e in TESTCASES)
            {
                Console.WriteLine($"Runing test case => J: {e.J}, S: {e.S}\nResult: {Solution(e.J, e.S)}\n\n");
            }
        }

        private static int Solution(string J, string S)
        {
            if (J.Length > 50 || S.Length > 50) return 0;

            int total = 0;
            foreach (var e in S) total += (J.Contains(e.ToString())) ? 1 : 0;

            return total;
        }
    }
}
