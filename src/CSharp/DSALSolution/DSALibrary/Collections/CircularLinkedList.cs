using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedList<T>
    {
        protected LinkedList<CircularLinkedListNode<T>> ListElements;

        public CircularLinkedList() => ListElements = new LinkedList<CircularLinkedListNode<T>>();

        public int Count => ListElements.Count;

        public void AddFirst(CircularLinkedListNode<T> node) => ListElements.AddFirst(node.ListNode);
    }
}
