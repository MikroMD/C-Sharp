using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string str = Console.ReadLine();

            if (str.Length > 0)
            {
                char[] test = str.ToCharArray();
                Array.Reverse(test);
                string reverse = new string(test);

                if (str.Equals(reverse, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"{str} is Palindrome.");
                else
                    Console.WriteLine($"{str} is not Palindrome.");
            }
            else
                Console.WriteLine($"{str} is empty.");
        }
    }
}
