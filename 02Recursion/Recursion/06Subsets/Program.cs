using System;

namespace _06Subsets
{
    class Program
    {
        static void Main()
        {
            int k = 2;
            string[] set = { "test", "rock", "fun" };
            int n = set.Length;
            int[] arr = new int[k];

            GenerateCombinations(arr, 0, 0, set);
        }

        public static void GenerateCombinations(int[] arr, int index, int start, string[] elements)
        {
            if (index >= arr.Length)
            {
                string[] items = new string[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    items[i] = elements[arr[i]];
                }
                Console.WriteLine(String.Join(", ", items));
            }
            else
            {
                for (int i = start; i < elements.Length; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, i + 1, elements);
                }
            }
        }
    }
}
