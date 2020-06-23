using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedList<T> : LinkedList<T>, ICircularIterable<T>
    {
        public ICircularIterator<T> GetCircularIterator() => this.Count > 0  ? new CircularIterator(this) : null;

        class CircularIterator : ICircularIterator<T>
        {
            LinkedList<T> linkedList;

            LinkedListNode<T> _current;

            public CircularIterator(LinkedList<T> listToIterate)
            {
                linkedList = listToIterate;
                Reset();
            }
            public void MoveNext()
            {
                _current = _current.Next ?? linkedList.First;
            }

            public void MovePrevious()
            {
                _current = _current.Previous ?? linkedList.Last;
            }

            public T Current() => _current.Value != null ? _current.Value : default(T);

            public void Reset()
            {
                _current = linkedList.First;
            }
        }
    }
}
