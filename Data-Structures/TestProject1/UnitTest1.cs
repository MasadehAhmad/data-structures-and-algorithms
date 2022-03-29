using Data_Structures.Data_structures.Linked_List;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void emptyLinked_List()
        {
            Linked_List list = new ();
            Assert.Null(list.head);
        }
        [Fact]
        public void insertionTest()
        {
            Linked_List list = new ();
            list.insert(55);
            Node current = list.head;
            Assert.Equal(55, current.value);
        }
        [Fact]
        public void firstNodeIsHead()
        {
            Linked_List list = new ();
            list.insert(5);
            list.insert(10);
            list.insert(9);
            Node current = list.head;
            Assert.Equal(9, current.value);
        }
        [Fact]
        public void InsertMultipleNodesTest()
        {
            Linked_List list = new();
            list.insert(1);
            list.insert(2);
            list.insert(3);
            Node current = list.head;
            Assert.Equal(3, current.value);
        }
        [Fact]
        public void isIncludesTest()
        {
            Linked_List list = new();
            list.insert(5);
            list.insert(10);
            list.insert(88);
            list.insert(77);
            Assert.True(list.includes(88));
        }
        [Fact]
        public void IncludesNotFoundTest()
        {
            Linked_List list = new();
            list.insert(5);
            list.insert(10);
            list.insert(88);
            list.insert(77);
            Assert.False(list.includes(55));
        }
        [Fact]
        public void ValesTest()
        {
            Linked_List list = new();
            list.insert(11);
            list.insert(22);
            list.insert(33);
            list.insert(52);
            list.insert(41);
            list.insert(23);
            Assert.Equal("[23] -> [41] -> [52] -> [33] -> [22] -> [11] -> NULL", list.toString());
        }
    }
}
