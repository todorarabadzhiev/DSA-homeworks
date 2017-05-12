namespace _11LinkedList
{
    public class ListItem<T>
    {
        private T value;
        private ListItem<T> nextItem;

        public ListItem(T value, ListItem<T> nextItem = null)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

        public T Value { get; set; }
        public ListItem<T> NextItem { get; set; }
    }
}
