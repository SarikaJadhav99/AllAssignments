using System;

namespace PalindromeOrNot
{
    class Program
    {
        // A recursive function that checks whether string is Palindrome or not
        static bool CheckPalindrome(String str, int start, int end)
        {
            //If there is only one character return true
            if (start == end)
                return true;

            //if 1st and last character do not match
            if (str[start] != str[end])
                return false;

            //if there are more than two characters, check if middle substring is palindrome or not

            if (start < end + 1)
                return CheckPalindrome(str, start + 1, end - 1);
            return true;
        }
        static bool IsPalindrome(String str)
        {
            int sizeOfString = str.Length;

            //empty string is considered as palindrome
            return (sizeOfString == 0) ? true : CheckPalindrome(str, 0, sizeOfString - 1);
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter the word :");
            String word = Console.ReadLine();
           
            Console.WriteLine(IsPalindrome(word)? true : false);

            Console.ReadLine();
        }
     }
}
