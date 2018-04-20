using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms.Strings
{
    // Challenge: https://www.hackerrank.com/challenges/strong-password/problem
    public class StrongPassword
    {
        public static int Resolve(byte n, string password) 
        {
            const short minimumLength = 6;
            const string  specialCharacters = "!@#$%^&*()-+";

            var total = new List<bool>() {
                password.Any(c => Char.IsDigit(c)),
                password.Any(c => Char.IsLower(c)),
                password.Any(c => Char.IsUpper(c)),
                password.Any(c => specialCharacters.Contains(c))
            }.Where(i => !i).Count();
            
            return Math.Max(total, minimumLength - n);
        }
    }
}
