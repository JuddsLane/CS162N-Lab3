using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
