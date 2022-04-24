using Data_Structures.Data_structures.stack_and_queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.stack_queue_pseudo
{
    public class StackQueuePseudo : Stack
    {
        public Stack stack1 { get; set; }
        public Stack stack2 { get; set; }

        public StackQueuePseudo()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }
        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack1.IsEmpty()) throw new Exception("Queue is empty");
            while (!stack1.IsEmpty()) stack2.Push(stack1.Pop());
            int value = stack2.Pop();
            while (!stack2.IsEmpty()) stack1.Push(stack2.Pop());
            return value;

        }
    }
}
