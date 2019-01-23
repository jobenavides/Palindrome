using System;

namespace Algorithm
{
    public static class StringHelper
    {        
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string Slice(this string word, int start, int end)
        {
            if (end < 0) 
            {
                end = word.Length + end;
            }
            int len = end - start;               
            return word.Substring(start, len); 
        }
    }
}
