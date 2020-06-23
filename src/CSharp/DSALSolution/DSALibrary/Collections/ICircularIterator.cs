using System.Collections.Generic;

namespace DSALibrary.Collections
{
    public interface ICircularIterator<T>
    {
        void MoveNext();

        void MovePrevious();

        T Current();

        void Reset();
    }
}
