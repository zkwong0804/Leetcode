/*
 * Question link: https://leetcode.com/problems/shuffle-string/
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Solutions
{
    class ShuffleString
    {
        public static void RunTest()
        {
            Console.WriteLine(Solution("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }));
            Console.WriteLine(Solution("abc", new int[] { 0, 1, 2 }));
            Console.WriteLine(Solution("aiohn", new int[] { 3, 1, 4, 2, 0 }));
            Console.WriteLine(Solution("aaiougrt", new int[] { 4, 0, 2, 6, 7, 3, 1, 5 }));
            Console.WriteLine(Solution("art", new int[] { 1, 0, 2 }));
        }

        private static string Solution(string s, int[] indices)
        {
            if (s.Length != indices.Length) return "";
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++) result[indices[i]] = s[i];

            return new string(result);
        }
    }
}
