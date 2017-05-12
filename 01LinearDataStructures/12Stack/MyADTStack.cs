using System;
using System.Linq;

namespace _12Stack
{
    public class MyADTStack<T>
    {
        private T[] stack;
        private int capacity;
        private int count;

        public MyADTStack()
        {
            this.capacity = 4;
            this.stack = new T[this.capacity];
            this.Count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }
        public void Push(T value)
        {
            if (this.Count == this.capacity)
            {
                this.capacity *= 2;
                Array.Resize(ref this.stack, this.capacity);
            }
            this.stack[this.Count] = value;
            this.Count++;
        }

        public T Pop()
        {
            T result = this.stack[this.Count-1];
            this.Count--;

            return result;
        }
    }
}
