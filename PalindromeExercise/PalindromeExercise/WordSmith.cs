using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            int start = 0;
            int end = str.Count()-1;
            bool isPalindrome = true;

            for (start = 0; start < end; start++, end--)
            {
                if (str[start] == str[end])
                    isPalindrome = true;
                else
                    isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
