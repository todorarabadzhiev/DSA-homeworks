using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SumAndAverage
{
    public class Program
    {
        public static void Main()
        {
            string strValue = Console.ReadLine();
            List<int> valuesList = new List<int>();
            int sum = 0;

            while (strValue != "")
            {
                int value = int.Parse(strValue);
                valuesList.Add(value);
                sum += value;
                strValue = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {sum}");

            float average = (float)sum / valuesList.Count();
            Console.WriteLine($"Average: {average}");
        }
    }
}
