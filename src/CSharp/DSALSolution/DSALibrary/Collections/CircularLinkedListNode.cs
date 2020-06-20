using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedListNode<T>
    {
        protected LinkedListNode<CircularLinkedListNode<T>> ListNode;

        public T Value { get; set;}

        public CircularLinkedListNode(T value)
        {
            this.Value = value;
            ListNode = new LinkedListNode<CircularLinkedListNode<T>>(this);
        }

        public CircularLinkedListNode<T> Next()
        {
            if (ListNode.List == null) return null;                         // No list available
            if (ListNode.Next == null) return ListNode.List.First.Value;    // loop to first 
            return ListNode.Next.Value;                                     // "Normal" next
        }

        public CircularLinkedListNode<T> Previous()
        {
            if (ListNode.List == null) return null;                         // No list available
            if (ListNode.Previous == null) return ListNode.List.Last.Value;    // loop to last 
            return ListNode.Previous.Value;                                     // "Normal" next
        }
    }
}
