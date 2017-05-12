using System;
using System.Collections.Generic;

namespace _05RemoveAllNegative
{
    public class Program
    {
        public static void Main()
        {
            List<int> sequence = new List<int>() { -4, 0, -3, 3, 1, -3, 3, 3, 8, 4, 2, -2, 4, -111, 1, 1, -1 };

            int count = sequence.Count - 1;
            for (int i = count; i >= 0; i--)
            {
                if (sequence[i] < 0)
                {
                    sequence.RemoveAt(i);
                }
            }

            Console.WriteLine(String.Join(", ", sequence));
        }
    }
}
