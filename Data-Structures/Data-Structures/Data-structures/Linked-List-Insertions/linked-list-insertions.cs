using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.Linked_List;

namespace Data_Structures.Data_structures.Linked_List_Insertions
{
    public class linkedListInsertions : LinkedList
    {
        public void append(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                count++;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next; 
            }
            current.next= newNode;
            count++;

        }
        public void insertBefore(int value,int newValue)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            if (head.value == value)
            {
                insert(newValue);
                return;
            }
            Node newNode = new Node(newValue);
            Node current = head;
            while (current.next != null)
            {
                if (current.next.value == value)
                {
                    newNode.next = current.next;
                    current.next = newNode;
                    count++;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine(value + " Doesn't exist");

        }
        public void insertAfter(int value, int newValue)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            };
            Node newNode = new Node(newValue);
            Node current = head;
            while (current != null)
            {
                if (current.value == value)
                {
                    newNode.next = current.next.next;
                    current.next = newNode;
                    count++;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine(value + " Doesn't exist");

        }
    }

}

