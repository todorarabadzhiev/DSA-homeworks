using System;

namespace _01NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;

            int[] arr = new int[N];

            GenerateCombinations(arr, 0);
        }

        public static void GenerateCombinations(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(", ", arr));
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[index] = i + 1;
                    GenerateCombinations(arr, index + 1);
                }
            }
        }   
    }
}
