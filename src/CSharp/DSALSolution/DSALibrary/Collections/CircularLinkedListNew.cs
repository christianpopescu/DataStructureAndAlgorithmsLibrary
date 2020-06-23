using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public class CircularLinkedListNew<T> : LinkedList<T>, ICircularIterable<T>
    {
        public ICircularIterator<T> GetCircularIterator()
        {
            throw new System.NotImplementedException();
        }

        class CircularIterator : ICircularIterator<T>
        {
            LinkedList<T> linkedList;

            CircularIterator(LinkedList<T> listToIterate)
            {
                linkedList = listToIterate;
            }
            public void MoveNext()
            {
                throw new System.NotImplementedException();
            }

            public void MovePrevious()
            {
                throw new System.NotImplementedException();
            }

            public T Current()
            {
                throw new System.NotImplementedException();
            }

            public void Reset()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
