using Xunit;
using DSALibrary.Collections;

namespace DSALibrary.Tests.Collections
{
    public class CircularLinkedListTest
    {
 

        [Fact]
        public void Check_Iterator()
        {
            CircularLinkedList<string> cllString = new CircularLinkedList<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            Assert.Equal("abc", cllString.Last.Value);

        }

        [Fact]
        public void Check_Current_on_First()
        {
            CircularLinkedList<string> cllString = new CircularLinkedList<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            cllString.AddLast("xyz");
            var ci = cllString.GetCircularIterator();

            Assert.Equal("def", ci.Current());

        }

        [Fact]
        public void Check_Next()
        {
            CircularLinkedList<string> cllString = new CircularLinkedList<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            cllString.AddLast("xyz");
            var ci = cllString.GetCircularIterator();
            ci.MoveNext();
            Assert.Equal("abc", ci.Current());

        }
        [Fact]
        public void Check_Previous()
        {
            CircularLinkedList<string> cllString = new CircularLinkedList<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            cllString.AddLast("xyz");
            var ci = cllString.GetCircularIterator();
            ci.MovePrevious();
            Assert.Equal("xyz", ci.Current());

        }
        [Fact]
        public void Check_Previous_Loop()
        {
            CircularLinkedList<string> cllString = new CircularLinkedList<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            cllString.AddLast("xyz");
            var ci = cllString.GetCircularIterator();
            ci.MovePrevious();
            Assert.Equal("xyz", ci.Current());
            ci.MovePrevious();
            Assert.Equal("abc", ci.Current());
            ci.MovePrevious();
            Assert.Equal("def", ci.Current());

        }

        [Fact]
        public void Current()
        {
            var cllString = new CircularLinkedList<string>();
            var ci = cllString.GetCircularIterator();
            Assert.Null(ci);

        }

    }
}
