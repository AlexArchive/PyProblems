using System;

namespace Interview.Stack
{
    public class Stack
    {
        public int Count { get; private set; }
        public int Capacity { get { return 10; } }

        private readonly int[] elements = new int[10];

        public void Push(int num)
        {
            if (Count == Capacity) throw new InvalidOperationException();

            elements[Count] = num;
            Count += 1;

        }

        public int Pop()
        {
            if (Count == 0) throw new InvalidOperationException();

            Count -= 1;
            var element = elements[Count];
            return element;
        }
    }
}