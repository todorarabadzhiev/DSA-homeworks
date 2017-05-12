using System;
using System.Collections.Generic;

namespace _09QueueSequence
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> sequence = new Queue<int>();
            int N = 2;
            int numberOfElements = 50;

            List<int> members = new List<int>() { N };
            sequence.Enqueue(N);

            while (members.Count < numberOfElements)
            {
                int S = sequence.Dequeue();
                int S1 = S + 1;
                int S2 = 2 * S + 1;
                int S3 = S + 2;

                sequence.Enqueue(S1);
                sequence.Enqueue(S2);
                sequence.Enqueue(S3);

                members.AddRange(new int[] { S1, S2, S3 });
            }

            while (members.Count > numberOfElements)
            {
                members.RemoveAt(members.Count - 1);
            }

            Console.WriteLine(String.Join(", ", members));
        }
    }
}
