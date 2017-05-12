namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private static IList<T> Merge(IList<T> collectionOne, IList<T> collectionTwo)
        {
            int cntOne = 0;
            int cntTwo = 0;
            IList<T> sortedCollection = new List<T>();
            while (cntOne < collectionOne.Count && cntTwo < collectionTwo.Count)
            {
                if (collectionOne[cntOne].CompareTo(collectionTwo[cntTwo]) <= 0)
                {
                    sortedCollection.Add(collectionOne[cntOne]);
                    cntOne++;
                }
                else
                {
                    sortedCollection.Add(collectionTwo[cntTwo]);
                    cntTwo++;
                }
            }

            while (cntOne<collectionOne.Count)
            {
                sortedCollection.Add(collectionOne[cntOne]);
                cntOne++;
            }

            while (cntTwo < collectionTwo.Count)
            {
                sortedCollection.Add(collectionTwo[cntTwo]);
                cntTwo++;
            }

            return sortedCollection;
        }

        private static IList<T> SortIt(IList<T> collection)
        {
            if (collection.Count == 1)
            {
                return collection;
            }

            int index = collection.Count / 2;
            var leftCollection = SortIt(collection.Take(index).ToList());
            var rightCollection = SortIt(collection.Skip(index).ToList());

            IList<T> sortedCollection = Merge(leftCollection, rightCollection);

            return sortedCollection;
        }

        public void Sort(IList<T> collection)
        {
            var sortedCollection = SortIt(collection);
            // За дооправяне
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = sortedCollection[i];
            }
        }
    }
}
