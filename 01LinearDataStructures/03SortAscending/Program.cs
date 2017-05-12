using System;
using System.Collections.Generic;

namespace _03SortAscending
{
    public class Program
    {
        public static void Main()
        {
            string strValue = Console.ReadLine();
            List<int> valuesList = new List<int>();

            while (strValue != "")
            {
                int value = int.Parse(strValue);
                int count = valuesList.Count;

                for (int i = 0; i < count; i++)
                {
                    if (value < valuesList[i])
                    {
                        valuesList.Insert(i, value);
                        break;
                    }
                }

                if (valuesList.Count == count)
                {
                    valuesList.Add(value);
                }

                strValue = Console.ReadLine();
            }

            foreach (var item in valuesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
