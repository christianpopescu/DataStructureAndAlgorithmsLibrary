using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedList<T>
    {
        protected LinkedList<CircularLinkedListNode<T>> ListElements;

        public CircularLinkedList() => ListElements = new LinkedList<CircularLinkedListNode<T>>();

        #region Properties
        public int Count => ListElements.Count;

        public CircularLinkedListNode<T> First => ListElements.First.Value;

        public CircularLinkedListNode<T> Last => ListElements.Last.Value;
        #endregion
        public void AddFirst(CircularLinkedListNode<T> node) => ListElements.AddFirst(node.ListNode);
    }
}
