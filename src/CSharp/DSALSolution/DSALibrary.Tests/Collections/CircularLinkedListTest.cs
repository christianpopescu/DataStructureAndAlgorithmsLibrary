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

        [Fact]
        public void Check_Iterator()
        {
            CircularLinkedListNew<string> cllString = new CircularLinkedListNew<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            Assert.Equal("abc", cllString.Last.Value);

        }

        [Fact]
        public void Check_Current_on_First()
        {
            CircularLinkedListNew<string> cllString = new CircularLinkedListNew<string>();
            cllString.AddFirst("abc");
            cllString.AddFirst("def");
            cllString.AddLast("xyz");
            var ci = cllString.GetCircularIterator();

            Assert.Equal("def", ci.Current());

        }

        [Fact]
        public void Check_Next()
        {
            CircularLinkedListNew<string> cllString = new CircularLinkedListNew<string>();
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
            CircularLinkedListNew<string> cllString = new CircularLinkedListNew<string>();
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
            CircularLinkedListNew<string> cllString = new CircularLinkedListNew<string>();
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
            var cllString = new CircularLinkedListNew<string>();
            var ci = cllString.GetCircularIterator();
            Assert.Null(ci);

        }

    }
}
