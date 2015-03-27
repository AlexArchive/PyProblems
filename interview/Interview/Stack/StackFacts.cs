using System;
using Xunit;

namespace Interview.Stack
{
    public class StackFacts
    {
        [Fact]
        public void PushIncrementsLength()
        {
            var sut = new Stack();
            sut.Push(1);
            sut.Push(2);
            Assert.Equal(2, sut.Count);
        }

        [Fact]
        public void CannotPushMoreThanTenNumbers()
        {
            var sut = new Stack();
            sut.Push(1);
            sut.Push(2);
            sut.Push(3);
            sut.Push(4);
            sut.Push(5);
            sut.Push(6);
            sut.Push(7);
            sut.Push(8);
            sut.Push(9);
            sut.Push(10);
            Assert.Throws<InvalidOperationException>(() => sut.Push(11));
        }

        [Fact]
        public void PopReturnsLastPushedNumber()
        {
            var sut = new Stack();
            var expected = 1;
            sut.Push(0);
            sut.Push(expected);
            var actual = sut.Pop();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CannotPopEmptyStack()
        {
            var sut = new Stack();
            sut.Push(1);
            sut.Push(2);
            sut.Push(3);
            sut.Pop();
            sut.Pop();
            sut.Pop();
            Assert.Throws<InvalidOperationException>(() => sut.Pop());
        }
    }
}