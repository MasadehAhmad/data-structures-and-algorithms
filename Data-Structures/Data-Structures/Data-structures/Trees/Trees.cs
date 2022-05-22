using System.Collections.Generic;

namespace Data_Structures.Data_structures.Trees
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
        public Node(int Data)
        {
            this.Right = null;
            this.Left = null;
            this.Data = Data;
        }
    }
    public class BinaryTree
    {
        public Node Root { get; set; }
        public bool flag { get; set; }
        public List<int> list { get; set; }

        public BinaryTree()
        {
            Root = null;
            list = new List<int>();
            flag = false;
        }
        public int[] InOrder(Node Root)
        {
            if (this.Root == Root) list.Clear();
            if (Root.Left != null)
                InOrder(Root.Left);

            list.Add(Root.Data);

            if (Root.Right != null)
                InOrder(Root.Right);
            return list.ToArray();
        }
        public List<int> PreOrder(Node Root)
        {
            if (this.Root == Root) list.Clear();
            list.Add(Root.Data);

            if (Root.Left != null)
                PreOrder(Root.Left);


            if (Root.Right != null)
                PreOrder(Root.Right);
            return list;
        }
        public int[] PostOrder(Node Root)
        {
            if (this.Root == Root) list.Clear();
            if (Root.Left != null)
                PostOrder(Root.Left);


            if (Root.Right != null)
                PostOrder(Root.Right);

            list.Add(Root.Data);
            return list.ToArray();
        }


    }
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int value)
        {
            Node parent = this.Root;
            Node current = this.Root;

            while (current != null)
            {
                parent = current;
                if (value < parent.Data)
                    current = current.Left;
                else
                    current = current.Right;

            }
            Node newNode = new Node(value);
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < parent.Data)
                    parent.Left = newNode;
                else
                    parent.Right = newNode;
            }
        }
        public void search(Node Root, int value)
        {
            if (this.Root == Root) flag = false;
            if (Root.Left != null)
                search(Root.Left, value);


            if (Root.Right != null)
                search(Root.Right, value);

            if (Root.Data == value) flag = true;

        }
        public bool contains(int value)
        {
            search(this.Root, value);
            return flag;
        }


    }
}
