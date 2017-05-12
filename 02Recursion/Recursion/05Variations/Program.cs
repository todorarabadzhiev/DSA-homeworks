using System;

namespace _05Variations
{
    class Program
    {
        static void Main()
        {
            int k = 2;
            string[] set = { "hi", "a", "b" };

            int[] arr = new int[k];

            GenerateCombinations(arr, 0, set);
        }

        public static void GenerateCombinations(int[] arr, int index, string[] elements)
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
                for (int i = 0; i < elements.Length; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, elements);
                }
            }
        }
    }
}
