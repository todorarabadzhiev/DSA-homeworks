using System;
using System.Collections.Generic;
using System.Linq;

namespace _04LongestSequenceOfEqualNumbers
{
    public class Program
    {
        public static List<int> FindLongestSequence(List<int> sequence)
        {
            int currentCountOfEquals = 0;
            int maxCountOfEquals = 0;
            int prevNumber = sequence.First();
            int theValue = prevNumber;
            foreach (var item in sequence)
            {
                if (item == prevNumber)
                {
                    currentCountOfEquals++;
                }
                else
                {
                    if (currentCountOfEquals > maxCountOfEquals)
                    {
                        maxCountOfEquals = currentCountOfEquals;
                        theValue = prevNumber;
                    }

                    currentCountOfEquals = 1;
                    prevNumber = item;
                }
            }

            if (currentCountOfEquals > maxCountOfEquals)
            {
                maxCountOfEquals = currentCountOfEquals;
                theValue = prevNumber;
            }

            return Enumerable.Repeat(theValue, maxCountOfEquals).ToList();
        }

        public static void Main()
        {
            List<int> sequence = new List<int>() { 1, 3, 3, 3, 3, 3, 3, 7, 8, 4, 2, 2, 4, 111, 1, 1, 1, 1, 1 };

            List<int> listOfEquals = FindLongestSequence(sequence);
            Console.WriteLine(String.Join(", ", listOfEquals));
        }
    }
}
