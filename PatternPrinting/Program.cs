using System;

namespace PatternPrinting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string word = Console.ReadLine();

            // To print odd index characters
            for (int i = 1; i <= word.Length; i += 2)
            {
                Console.WriteLine(word.Substring(0, i));
            }
            Console.WriteLine("\n");

            PrintPyramid(word);
        }

        public static void PrintPyramid(string word)
        {
            Console.WriteLine("Enter the number of rows : ");

            int rows = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write(word[k - 1] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
