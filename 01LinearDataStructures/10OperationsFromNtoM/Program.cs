using System;
using System.Collections.Generic;

namespace _10OperationsFromNtoM
{
    public class Program
    {
        public static Stack<int> FindNumberSequence(int N, int M)
        {
            Stack<int> result = new Stack<int>();
            int val = M;

            result.Push(val);
            while (val / 2 >= N)
            {
                if (val % 2 == 1)
                {
                    val -= 1;
                    result.Push(val);
                }

                val /= 2;
                result.Push(val);
            }

            while (val - 2 >= N)
            {
                val -= 2;
                result.Push(val);
            }

            while (val - 1 >= N)
            {
                val -= 1;
                result.Push(val);
            }

            return result;
        }

        public static void Main()
        {
            int N = 5;
            int M = 16;

            // faster for large M
            Stack<int> result = FindNumberSequence(N, M);

            //List<int> result = FindWithQueue(N, M);

            Console.WriteLine(String.Join("->", result));
        }

        public static List<int> FindWithQueue(int N, int M)
        {
            Queue<int> queue = new Queue<int>();
            List<int> sequence = new List<int>() { N };
            queue.Enqueue(N);

            while (!queue.Contains(M))
            {
                int value = queue.Dequeue();
                int v1 = value + 1;
                int v2 = value + 2;
                int v3 = value * 2;
                queue.Enqueue(v1);
                queue.Enqueue(v2);
                queue.Enqueue(v3);
                sequence.AddRange(new int[] { v1, v2, v3 });
            }

            Stack<int> indices = new Stack<int>();
            int index = sequence.IndexOf(M);
            while (index > 0)
            {
                indices.Push(index);
                index = (index - 1) / 3;
            }

            indices.Push(0);

            List<int> result = new List<int>();
            while (indices.Count > 0)
            {
                result.Add(sequence[indices.Pop()]);
            }

            return result;
        }
    }
}
