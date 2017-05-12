using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    public class MinHeap<T> where T : IComparable
    {
        private IList<T> minHeap;
        public MinHeap()
        {
            this.minHeap = new List<T>();

            // IGNORING 0-th VALUE
            this.minHeap.Add(default(T));
        }

        public T GetTop()
        {
            if (this.minHeap.Count < 2)
            {
                throw new ArgumentOutOfRangeException("The HEAP is empty!");
            }

            return this.minHeap[1];
        }

        public void AddValue(T value)
        {
            this.minHeap.Add(value);
            int index = (this.minHeap.Count() - 1);
            int parentIndex = index / 2;
            while (parentIndex > 0 && this.minHeap[parentIndex].CompareTo(value) > 0)
            {
                this.SwapValues(index, parentIndex);
                index = parentIndex;
                parentIndex /= 2;
            }
        }

        public void RemoveTop()
        {
            this.SwapValues(1, this.minHeap.Count - 1);
            this.minHeap.RemoveAt(this.minHeap.Count - 1);

            this.Sink(1);
        }

        private void Sink(int startIndex)
        {
            if (startIndex > this.minHeap.Count - 1 || startIndex < 1)
            {
                return;
            }

            int index = startIndex;
            int leftChildIndex = index * 2;
            int rightChildIndex = index * 2 + 1;
            if (rightChildIndex < this.minHeap.Count)
            {
                int minChildIndex = this.minHeap[leftChildIndex].CompareTo(this.minHeap[rightChildIndex]) < 0 ?
                    leftChildIndex : rightChildIndex;

                while (this.minHeap[minChildIndex].CompareTo(this.minHeap[index]) < 0)
                {
                    this.SwapValues(index, minChildIndex);
                    index = minChildIndex;
                    leftChildIndex = index * 2;
                    rightChildIndex = index * 2 + 1;
                    if (rightChildIndex < this.minHeap.Count)
                    {
                        minChildIndex = this.minHeap[leftChildIndex].CompareTo(this.minHeap[rightChildIndex]) < 0 ?
                            leftChildIndex : rightChildIndex;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (leftChildIndex < this.minHeap.Count &&
                this.minHeap[leftChildIndex].CompareTo(this.minHeap[index]) < 0)
            {
                this.SwapValues(index, leftChildIndex);
            }
        }

        private void SwapValues(int index, int parentIndex)
        {
            T temp = this.minHeap[index];
            this.minHeap[index] = this.minHeap[parentIndex];
            this.minHeap[parentIndex] = temp;
        }

        public override string ToString()
        {
            return string.Join(" ", this.minHeap);
        }
    }
}
