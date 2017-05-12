namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private void SortIt(IList<T> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                T current = collection[i];
                int minIndex = FindMinIndex(collection, i);
                Swap(collection, i, minIndex);
            }
        }

        private void Swap(IList<T> collection, int i, int minIndex)
        {
            if (i == minIndex)
            {
                return;
            }

            T temp = collection[i];
            collection[i] = collection[minIndex];
            collection[minIndex] = temp;
        }

        private int FindMinIndex(IList<T> collection, int start)
        {
            int minIndex = start;
            T minValue = collection[minIndex];
            for (int i = start + 1; i < collection.Count; i++)
            {
                if (collection[i].CompareTo(minValue) < 0)
                {
                    minValue = collection[i];
                    minIndex = i;
                }
            };

            return minIndex;
        }

        public void Sort(IList<T> collection)
        {
            SortIt(collection);
        }
    }
}
