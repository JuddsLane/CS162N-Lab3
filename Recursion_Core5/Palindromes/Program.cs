using System;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string userString = Regex.Replace(Console.ReadLine(), "[^a-zA-Z0-9]", "");
            Console.WriteLine((IsPalindrome(userString) == true) ? "String is a palindrome" : "String is not a palindrome");

            static bool IsPalindrome(string s)
            {
                if (s.Length <= 1)
                    return true;
                if (s[0] != s[s.Length - 1])
                    return false;
                return IsPalindrome(s.Substring(1, s.Length - 2));
            }
        }
    }
}
