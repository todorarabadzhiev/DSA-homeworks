namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            SortIt(collection, 0, collection.Count - 1);

        }

        private void SortIt(IList<T> collection, int left, int right)
        {
            int i = left, j = right;
            T pivot = collection[(left + right) / 2];

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(collection, i, j);

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                SortIt(collection, left, j);
            }

            if (i < right)
            {
                SortIt(collection, i, right);
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
    }
}
