using System;

namespace _12Stack
{
    public class Program
    {
        public static void Main()
        {
            int N = 100;
            MyADTStack<int> stack = new MyADTStack<int>();
            for (int i = 0; i < N; i++)
            {
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
