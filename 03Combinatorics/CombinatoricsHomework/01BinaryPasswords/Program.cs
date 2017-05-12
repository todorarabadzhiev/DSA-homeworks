using System;
using System.Linq;

namespace _01BinaryPasswords
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char star = '*';
            int countOfStars = input.Count(ch => ch == star);
            long result = 1;
            for (int i = 1; i <= countOfStars; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}
