using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ColorRabbits
{
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<int> unique = new List<int>();
            List<int> all = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                all.Add(number);
                if (!unique.Contains(number))
                {
                    unique.Add(number);
                }
            }

            int rabitCount = 0;
            for (int i = 0; i < unique.Count; i++)
            {
                int numberOfValue = all.FindAll(a => a == unique[i]).Count();
                int numberOfColors = (numberOfValue - 1) / (unique[i] + 1) + 1;

                rabitCount += (unique[i] + 1) * numberOfColors;
            }

            Console.WriteLine(rabitCount);
        }
    }
}
