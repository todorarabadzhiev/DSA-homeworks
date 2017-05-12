using System;

namespace _13LinkedQueue
{
    public class Program
    {
        public static void Main()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(21);
            queue.Enqueue(13);
            queue.Enqueue(4);

            while (queue.FirstElement != null)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
