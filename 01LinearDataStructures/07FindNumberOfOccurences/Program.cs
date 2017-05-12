using System;
using System.Collections.Generic;

namespace _07FindNumberOfOccurences
{
    public class Program
    {
        public static void Main()
        {
            List<int> sequence = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            List<int> uniqueValues = new List<int>();
            List<int> numberOccurences = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                int index = uniqueValues.IndexOf(sequence[i]);
                if (index > -1)
                {
                    numberOccurences[index]++;
                }
                else
                {
                    uniqueValues.Add(sequence[i]);
                    numberOccurences.Add(1);
                }
            }

            for (int i = 0; i < uniqueValues.Count; i++)
            {
                Console.WriteLine($"{uniqueValues[i]} -> {numberOccurences[i]} times");
            }
        }
    }
}
