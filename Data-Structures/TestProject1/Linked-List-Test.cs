using Data_Structures.Data_structures.Linked_List;
using Data_Structures.Data_structures.Linked_List_Insertions;
using Data_Structures.Data_structures.linked_list_kth;
using Data_Structures.Data_structures.linked_list_zip;
using System;
using Xunit;

namespace TestProject1
{
    public class LinkedListTest
    {
        [Fact]
        public void emptyLinked_List()
        {
            LinkedList list = new();
            Assert.Null(list.head);
        }
        [Fact]
        public void insertionTest()
        {
            LinkedList list = new();
            list.insert(55);
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
            Assert.Equal(55, current.value);
        }
        [Fact]
        public void firstNodeIsHead()
        {
            LinkedList list = new();
            list.insert(5);
            list.insert(10);
            list.insert(9);
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
            Assert.Equal(9, current.value);
        }
        [Fact]
        public void InsertMultipleNodesTest()
        {
            LinkedList list = new();
            list.insert(1);
            list.insert(2);
            list.insert(3);
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
            Assert.Equal(3, current.value);
        }
        [Fact]
        public void isIncludesTest()
        {
            LinkedList list = new();
            list.insert(5);
            list.insert(10);
            list.insert(88);
            list.insert(77);
            Assert.True(list.includes(88));
        }
        [Fact]
        public void notFoundTest()
        {
            LinkedList list = new();
            list.insert(5);
            list.insert(10);
            list.insert(88);
            list.insert(77);
            Assert.False(list.includes(55));
        }
        [Fact]
        public void checkValue()
        {
            LinkedList list = new();
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
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
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
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
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
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
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
            Data_Structures.Data_structures.Linked_List.Node current = list.head;
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
        [Fact]
        public void kGreaterThanLength()
        {
            linkedListkth list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            Assert.Throws<IndexOutOfRangeException>(() => list.kthElemante(5, list));
        }
        [Fact]
        public void kNotPositive()
        {
            linkedListkth list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            Assert.Throws<Exception>(() => list.kthElemante(-5, list));
        }
        [Fact]
        public void kSameAsLength()
        {
            linkedListkth list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            Assert.Equal(5, list.kthElemante(3, list));
        }
        [Fact]
        public void kLength1()
        {
            linkedListkth list = new();
            list.append(5);
            Assert.Equal(5, list.kthElemante(0, list));
        }
        [Fact]
        public void kthElemanteTest()
        {
            linkedListkth list = new();
            list.append(5);
            list.append(10);
            list.append(44);
            list.append(75);
            list.append(55);
            Assert.Equal(44, list.kthElemante(2, list));
        }





        [Fact]
        public void zipTestSameLength()
        {
            linkedListInsertions list1 = new();
            list1.append(5);
            list1.append(10);
            list1.append(44);
            list1.append(75);
            linkedListInsertions list2 = new();
            list2.append(7);
            list2.append(16);
            list2.append(96);
            list2.append(788);
            linkedListInsertions newList = linkedlistZip.Zip(list1, list2);
            Assert.Equal("[5] -> [7] -> [10] -> [16] -> [44] -> [96] -> [75] -> [788] -> NULL", newList.toString());

        }
        [Fact]
        public void zipTestList2Longer()
        {
            linkedListInsertions list1 = new();
            list1.append(5);
            list1.append(10);
            list1.append(44);
            linkedListInsertions list2 = new();
            list2.append(7);
            list2.append(16);
            list2.append(96);
            list2.append(788);
            linkedListInsertions newList = linkedlistZip.Zip(list1, list2);
            Assert.Equal("[5] -> [7] -> [10] -> [16] -> [44] -> [96] -> [788] -> NULL", newList.toString());

        }
        [Fact]
        public void zipTestList1longer()
        {
            linkedListInsertions list1 = new();
            list1.append(5);
            list1.append(10);
            list1.append(44);
            list1.append(75);
            linkedListInsertions list2 = new();
            list2.append(7);
            list2.append(16);
            list2.append(96);
            linkedListInsertions newList = linkedlistZip.Zip(list1, list2);
            Assert.Equal("[5] -> [7] -> [10] -> [16] -> [44] -> [96] -> [75] -> NULL", newList.toString());

        }

    }


}
