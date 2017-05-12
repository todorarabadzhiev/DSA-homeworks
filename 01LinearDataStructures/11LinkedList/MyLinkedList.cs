namespace _11LinkedList
{
    public class MyLinkedList<T>
    {
        public MyLinkedList(ListItem<T> firstElement)
        {
            this.FirstElement = firstElement;
        }

        public ListItem<T> FirstElement { get; set; }
    }
}
