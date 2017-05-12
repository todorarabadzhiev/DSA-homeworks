using _11LinkedList;
using System;

namespace _13LinkedQueue
{
    public class LinkedQueue<T> : MyLinkedList<T>
    {
        public int Count { get; set; }
        public LinkedQueue()
            :base(null)
        {
            this.LastElement = null;
            this.Count = 0;
        }

        private ListItem<T> LastElement { get; set; }

        public void Enqueue(T element)
        {
            ListItem<T> el = new ListItem<T>(element);
            if (this.FirstElement == null)
            {
                this.FirstElement = el;
                this.LastElement = el;
            }
            else
            {
                ListItem<T> preLastElement = this.LastElement;
                this.LastElement = el;
                preLastElement.NextItem = this.LastElement;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("Empty queue");
            }

            ListItem<T> el = this.FirstElement;
            this.FirstElement = el.NextItem;
            this.Count--;

            return el.Value;
        }
    }
}
