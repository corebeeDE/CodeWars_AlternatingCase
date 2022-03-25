using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars_AlternatingCase
{
    class Program
    {
        static void Main()
        {
            // https://www.codewars.com/kata/56efc695740d30f963000557/
            Console.WriteLine(ToAlternatingCase("loLLLLLlelel"));
            Console.WriteLine(ToAlternatingCaseTwo("loLLLLLlelel"));
        }

        // First solution:
        public static string ToAlternatingCase(string s)
        {
            return new string (s.Select(x => x > 64 && x < 91 ? (char)(x+32) : x > 96 && x < 123 ? (char)(x-32) : x).ToArray());
        }

        // Refactored solution:
        public static string ToAlternatingCaseTwo(string s)
        {
            return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        }
    }
}
