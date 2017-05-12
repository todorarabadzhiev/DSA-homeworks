using System;

namespace PriorityQueue
{
    public class Program
    {
        private static readonly Random randGen = new Random();

        public static void Main()
        {
            TestHeap();
        }

        private static void TestHeap()
        {
            MinHeap<int> myHeap = new MinHeap<int>();

            int N = 17;
            for (int i = 0; i < N; i++)
            {
                int nextValue = randGen.Next(0, 1000);
                myHeap.AddValue(nextValue);
                Console.WriteLine(nextValue);
            }

            Console.WriteLine(myHeap);

            myHeap.RemoveTop();
            Console.WriteLine(myHeap);
        }
    }
}
