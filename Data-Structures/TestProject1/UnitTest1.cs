using Data_Structures.Data_structures.Linked_List;
using Data_Structures.Data_structures.Linked_List_Insertions;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void emptyLinked_List()
        {
            linkedList list = new ();
            Assert.Null(list.head);
        }
        [Fact]
        public void insertionTest()
        {
            linkedList list = new ();
            list.insert(55);
            Node current = list.head;
            Assert.Equal(55, current.value);
        }
        [Fact]
        public void firstNodeIsHead()
        {
            linkedList list = new ();
            list.insert(5);
            list.insert(10);
            list.insert(9);
            Node current = list.head;
            Assert.Equal(9, current.value);
        }
        [Fact]
        public void InsertMultipleNodesTest()
        {
            linkedList list = new();
            list.insert(1);
            list.insert(2);
            list.insert(3);
            Node current = list.head;
            Assert.Equal(3, current.value);
        }
        [Fact]
        public void isIncludesTest()
        {
            linkedList list = new();
            list.insert(5);
            list.insert(10);
            list.insert(88);
            list.insert(77);
            Assert.True(list.includes(88));
        }
        [Fact]
        public void notFoundTest()
        {
            linkedList list = new();
            list.insert(5);
            list.insert(10);
            list.insert(88);
            list.insert(77);
            Assert.False(list.includes(55));
        }
        [Fact]
        public void checkValue()
        {
            linkedList list = new();
            list.insert(11);
            list.insert(22);
            list.insert(33);
            list.insert(52);
            list.insert(41);
            list.insert(23);
            Assert.Equal("[23] -> [41] -> [52] -> [33] -> [22] -> [11] -> NULL", list.toString());
        }


        [Fact]
        public void addNodeToEnd()
        {
            linkedListInsertions list = new();
            list.append(5);
            Node current = list.head;
            while (current.next != null)
            {
                current = current.next;
            }
            Assert.Equal(5, current.value);
        }

        [Fact]
        public void multipleAddNodeToEnd()
        {
            linkedListInsertions list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            Node current = list.head;
            while (current.next != null)
            {
                current = current.next;
            }
            Assert.Equal(75, current.value);
        }

        [Fact]
        public void insertNodeBefore()
        {
            linkedListInsertions list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            list.insertBefore(44, 99);
            Node current = list.head;
            while (current.next.value != 44)
            {
                current = current.next;
            }
            Assert.Equal(99, current.value);
        }
        [Fact]
        public void insertNodeBeforeFirst()
        {
            linkedListInsertions list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            list.insertBefore(5, 88);
            Assert.Equal(88, list.head.value);
        }
        [Fact]
        public void insertNodeAfter()
        {
            linkedListInsertions list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            list.insertAfter(44, 77);
            Node current = list.head;
            while (current.value != 44)
            {
                current = current.next;
            }
            Assert.Equal(77, current.next.value);
        }
        [Fact]
        public void insertNodeAfterFirst()
        {
            linkedListInsertions list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            list.insertAfter(5, 66);
            Assert.Equal(66, list.head.next.value);
        }

    }


}
