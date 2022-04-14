using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Structures.Data_structures.stack_and_queue
{
    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
            next = null;
        }
    }
    public class Stack
    {
        public Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;

        }

        public int Pop()
        {
            if (top == null) throw new Exception("Stack is empty");
            Node temp = top;
            top = top.next;
            return temp.value;
        }

        public int Peek()
        {
            if (top == null) throw new Exception("Stack is empty");
            return top.value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }


    public class Queue
    {
        public Node front;
        public Node rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null) throw new Exception("Queue is empty");

            Node temp = front;
            front = front.next;

            if (front == null) rear = null;

            return temp.value;
        }

        public int Peek()
        {
            if (front == null) throw new Exception("Queue is empty");
            return front.value;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
