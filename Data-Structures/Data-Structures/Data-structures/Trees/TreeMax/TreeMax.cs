using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.Trees
{
    public class TreeMax : BinaryTree
    {
        public int max;

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
        public int GetMax(Node Root)
        {
            if (this.Root == Root) max = Root.Data;

            if (Root.Left != null)
                GetMax(Root.Left);

            if (Root.Right != null)
                GetMax(Root.Right);

            if (Root.Data > max) max = Root.Data;
            return max;
        }
    }
}
