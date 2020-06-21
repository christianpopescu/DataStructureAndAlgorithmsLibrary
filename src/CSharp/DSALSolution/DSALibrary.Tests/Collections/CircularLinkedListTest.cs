using Xunit;
using DSALibrary.Collections;

namespace DSALibrary.Tests.Collections
{
    public class CircularLinkedListTest
    {
        protected CircularLinkedList<int> cllInt = new CircularLinkedList<int>();

        [Fact]
        public void CountForEmtpyListIs0()
        {
            Assert.Equal(0, cllInt.Count);

        }
 
        [Fact]
        public void TwoAddFirst_Count_2()
        {
            cllInt.AddFirst(new CircularLinkedListNode<int>(10));
            cllInt.AddFirst(new CircularLinkedListNode<int>(10));
            Assert.Equal(2, cllInt.Count);
        }

        [Fact]
        public void Property_First()
        {
            CircularLinkedList<int> cllInt = new CircularLinkedList<int>();
            cllInt.AddFirst(new CircularLinkedListNode<int>(10));
            cllInt.AddFirst(new CircularLinkedListNode<int>(20));
            Assert.Equal(20, cllInt.First.Value);

        }

        [Fact]
        public void Property_Last()
        {
            CircularLinkedList<string> cllString = new CircularLinkedList<string>();
            cllString.AddFirst(new CircularLinkedListNode<string>("abc"));
            cllString.AddFirst(new CircularLinkedListNode<string>("def"));
            Assert.Equal("abc", cllString.Last.Value);

        }
    }
}
