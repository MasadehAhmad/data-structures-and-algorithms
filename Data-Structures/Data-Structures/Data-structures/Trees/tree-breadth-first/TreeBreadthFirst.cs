using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.Trees
{
    public class TreeBreadthFirst : BinarySearchTree
    {
        public List<int> breadthFirst(Node root)
        {
            List<int> result = new List<int>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.Count > 0)
            {
                Node front = breadth.Dequeue();
                result.Add(front.Data);


                if (front.Left != null)
                    breadth.Enqueue(front.Left);

                if (front.Right != null)
                    breadth.Enqueue(front.Right);
            }

            return result;

        }


       
    }
}
