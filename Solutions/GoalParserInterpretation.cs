/*
 * 
 * Quesion link: https://leetcode.com/problems/goal-parser-interpretation/
 * 
 */

using System;

namespace Leetcode.Solutions
{
    class GoalParserInterpretation
    {
        public static void RunTest()
        {
            Console.WriteLine(Solution("G()(al)")); 
            Console.WriteLine(Solution("G()()()()(al)")); 
            Console.WriteLine(Solution("(al)G(al)()()G")); 
        }

        private static string Solution(string command)
        {
            string result = "";
            result = command.Replace("()", "o");
            result = result.Replace("(al)", "al");
            return result;
        }
    }
}
