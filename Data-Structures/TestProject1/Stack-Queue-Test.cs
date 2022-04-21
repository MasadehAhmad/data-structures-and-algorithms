using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.stack_and_queue;
using Xunit;

namespace TestProject1
{
    public class StackQueueTest
    {
        [Fact]
        public void StackPush()
        {
            Stack stack = new Stack();
            stack.Push(50);
            stack.Push(60);
            stack.Push(42);
            Assert.Equal(42, stack.Peek());
        }

        [Fact]
        public void StackPop()
        {
            Stack stack = new Stack();
            stack.Push(50);
            stack.Push(60);
            Assert.Equal(60, stack.Peek());
            Assert.Equal(60, stack.Pop());
            Assert.Equal(50, stack.Peek());
        }

        [Fact]
        public void EmptyTheStack()
        {
            Stack stack = new Stack();
            stack.Push(50);
            stack.Push(90);
            Assert.False(stack.IsEmpty());
            stack.Pop();
            stack.Pop();
            Assert.True(stack.IsEmpty());
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void StackPeek()
        {
            Stack stack = new Stack();
            stack.Push(80);
            Assert.Equal(80, stack.Peek());
            stack.Push(90);
            Assert.Equal(90, stack.Peek());
        }

        [Fact]
        public void StackIsEmpty()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void PopPeekEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Throws<Exception>(() => stack.Peek());
            Assert.Throws<Exception>(() => stack.Pop());

        }



        [Fact]
        public void InsertIntoQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            Assert.Equal(40, queue.Peek());
            Assert.Equal(60, queue.rear.value);
        }

        [Fact]
        public void DeleteFromQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(40);
            queue.Enqueue(50);
            Assert.Equal(40, queue.Dequeue());
        }

        [Fact]
        public void PeekQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(40);
            queue.Enqueue(20);
            queue.Enqueue(80);
            Assert.Equal(40, queue.Peek());
        }

        [Fact]
        public void EmptyTheQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(60);
            Assert.False(queue.IsEmpty());
            queue.Dequeue();
            queue.Dequeue();
            Assert.True(queue.IsEmpty());
            Assert.Null(queue.front);
            Assert.Null(queue.rear);
            Assert.Throws<Exception>(() => queue.Dequeue());

        }

        [Fact]
        public void QueueIsEmptyTest()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void DequeuePeekEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.Throws<Exception>(() => queue.Peek());
            Assert.Throws<Exception>(() => queue.Dequeue());
        }
    }
}
