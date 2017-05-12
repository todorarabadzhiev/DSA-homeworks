using System;

namespace _11LinkedList
{
    public class Program
    {
        public static void Main()
        {
            ListItem<int> fifth = new ListItem<int>(5);
            ListItem<int> fourth = new ListItem<int>(4, fifth);
            ListItem<int> third = new ListItem<int>(3,fourth);
            ListItem<int> second = new ListItem<int>(2, third);
            ListItem<int> first = new ListItem<int>(1, second);

            MyLinkedList<int> linkedList = new MyLinkedList<int>(first);

            ListItem<int> current = linkedList.FirstElement;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.NextItem;
            }
        }
    }
}
