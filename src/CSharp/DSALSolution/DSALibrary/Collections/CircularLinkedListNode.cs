using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedListNode<T>
    {
        private LinkedListNode<CircularLinkedListNode<T>> _listNode;

        public T Value { get; set;}

        public CircularLinkedListNode(T value)
        {
            this.Value = value;
            _listNode = new LinkedListNode<CircularLinkedListNode<T>>(this);
        }

        public LinkedListNode<CircularLinkedListNode<T>> ListNode => _listNode;

        public CircularLinkedListNode<T> Next()
        {
            if (_listNode.List == null) return null;                         // No list available
            if (_listNode.Next == null) return _listNode.List.First.Value;    // loop to first 
            return _listNode.Next.Value;                                     // "Normal" next
        }

        public CircularLinkedListNode<T> Previous()
        {
            if (_listNode.List == null) return null;                         // No list available
            if (_listNode.Previous == null) return _listNode.List.Last.Value;    // loop to last 
            return _listNode.Previous.Value;                                     // "Normal" next
        }
    }
}
