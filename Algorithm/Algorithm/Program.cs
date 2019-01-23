using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //var palindrome = Palindrome.LongestPalindrome("bmb 444414444 4949 stats");
            //var palindrome = Palindrome.LongestPalindrome("121 lol level 444454");
            Console.WriteLine("Insert text to evaluate: ");
            var text = Console.ReadLine();

            var palindrome = Palindrome.LongestPalindrome(text);

            Console.WriteLine(palindrome);
            Console.ReadLine();
        }
    }
}
