namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var it in this.Items)
            {
                if (it.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            this.Sort(new MergeSorter<T>());

            int left = 0;
            int right = this.Items.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (this.items[mid].Equals(item))
                {
                    return true;
                }

                if (this.items[mid].CompareTo(item) > 0)
                {
                    if (mid < right)
                    {
                        right = mid;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (mid > left)
                    {
                        left = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return false;
        }

        public void Shuffle()
        {
            for (int i = 0; i < this.Items.Count - 2; i++)
            {
                int j = RandomGen.RandomInt(i, this.Items.Count);
                this.Swap(i, j);
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }

        private void Swap(int i, int j)
        {
            if (i == j)
            {
                return;
            }

            T temp = this.Items[i];
            this.Items[i] = this.Items[j];
            this.Items[j] = temp;
        }
    }
}
