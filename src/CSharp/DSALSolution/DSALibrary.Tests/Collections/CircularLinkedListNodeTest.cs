using Xunit;
using DSALibrary.Collections;

namespace DSALibrary.Tests.Collections
{
    public class CircularLinkedListNode
    {
        [Fact]
        public void CheckInitValue()
        {
            var clln = new CircularLinkedListNode<int>(10);
            Assert.Equal(10, clln.Value);
        }
    }
}