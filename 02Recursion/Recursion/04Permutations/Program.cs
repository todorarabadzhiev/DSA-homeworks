using System;
using System.Linq;

namespace _04Permutations
{
    class Program
    {
        static void Main()
        {
            int n = 4;

            int[] arr = new int[n];

            GeneratePermutations(arr, 0);
        }

        private static void GeneratePermutations(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(", ", arr));
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int next = i + 1;
                    if (!arr.Contains(next))
                    {
                        arr[index] = next;
                        GeneratePermutations(arr, index + 1);
                        arr[index] = 0;
                    }
                }
            }
        }
    }
}
