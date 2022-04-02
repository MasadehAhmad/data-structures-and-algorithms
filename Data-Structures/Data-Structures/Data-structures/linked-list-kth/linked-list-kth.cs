using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Structures.Data_structures.linked_list_kth
{
    public class Node
    {
        public int value;
        public Node last;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            next = null;
            last = null;
        }
    }
    public class linked_list_kth
    {
        public Node head;
        public Node tail;
        public int kthElemante(int k) 
        {
            if (k < 0) throw new Exception();
            Node current = tail;
            for (int i = 0; i < k; i++)
            {
                current = current.last;
                if (current == null) throw new IndexOutOfRangeException();
            }
            return current.value;
        }
        public void append(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }
            tail.next = newNode;
            newNode.last = tail;
            tail = newNode;

        }
    }
}
