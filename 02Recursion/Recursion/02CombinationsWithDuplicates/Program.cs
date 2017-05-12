using System;

namespace _02CombinationsWithDuplicates
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int k = 3;

            int[] arr = new int[k];

            GenerateCombinations(arr, 0, 1, n);
        }

        public static void GenerateCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(", ", arr));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, i, end);
                }
            }
        }
    }
}
