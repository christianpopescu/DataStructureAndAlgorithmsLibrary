using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedListNew<T> : LinkedList<T>, ICircularIterable<T>
    {
        public ICircularIterator<T> GetCircularIterator()
        {
            throw new System.NotImplementedException();
        }
    }
}
