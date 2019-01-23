using System;

namespace Algorithm
{
    public static class Palindrome
    {
        private static bool IsPalindrome(string word)
        {            
            return StringHelper.ReverseString(word) == word;
        }

        public static string LongestPalindrome(string word)
        {
            var longest = "";

            for(var i = 0; i<= word.Length - 1; i++)
            {               
                for (var j = 1; j <= word.Length - 1; j++)
                {                    
                    var substring = word.Substring(i, j > word.Substring(i).Length ? word.Substring(i).Length - 1 : j);
                    if(j < word.Substring(i).Length)
                    {                        
                        if (IsPalindrome(substring) && substring.Length > longest.Length)
                            longest = substring;
                    }                   
                }               
            }

            return longest;
        }
    }
}
