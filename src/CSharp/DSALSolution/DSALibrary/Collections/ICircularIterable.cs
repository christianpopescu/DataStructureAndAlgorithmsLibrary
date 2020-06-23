namespace DSALibrary.Collections
{
    public interface ICircularIterable<T>
    {
        ICircularIterator<T> GetCircularIterator();
    }
}
