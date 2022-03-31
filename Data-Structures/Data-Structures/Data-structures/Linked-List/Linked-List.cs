using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.Linked_List
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
        }
    }
    public class linkedList
    {
       

        public Node head;

        public void insert(int value)
        {
            Node node = new Node(value);
            node.next = head;
            head = node;
            
        }

        public bool includes(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.value == value)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public string toString()
        {
            string result = "";
            Node current = head;
            while (current != null)
            {
                result += $"[" + current.value + "] -> ";
                current = current.next;
            }
            result += "NULL";
            return result;
        }
    }

   
}











