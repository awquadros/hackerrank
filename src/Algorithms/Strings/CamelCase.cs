using System;
using System.Text.RegularExpressions;

namespace Algorithms.Strings
{
    // Challenge: https://www.hackerrank.com/challenges/camelcase/problem
    public class CamelCase
    {
        public static int Resolve(string s) 
        {
            return Regex.Matches(s, "([A-Z]{1}[a-z]*)").Count + 1;
        }
    }
}
