using System;
using System.Collections.Generic;

namespace _02ReverseNInts
{
    public class Program
    {
        public static void Main()
        {
            int N = 10;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stack.Push(value);
            }

            Console.WriteLine("--------");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
