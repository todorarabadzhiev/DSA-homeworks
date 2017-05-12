using System;
using System.Collections.Generic;

namespace _06RemoveNumbersOccuringOddTimes
{
    public class Program
    {
        public static void Main()
        {
            List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

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
                if (numberOccurences[i] % 2 == 1)
                {
                    sequence.RemoveAll(item => item == uniqueValues[i]);
                }
            }

            Console.WriteLine(String.Join(", ", sequence));
        }
    }
}
