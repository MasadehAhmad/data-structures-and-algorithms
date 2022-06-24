using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.Trees;

namespace Data_Structures.Data_structures.tree_intersection
{
    public class TreeIntersection
    {
        public List<int> Intersection(BinarySearchTree tree1 , BinarySearchTree tree2)
        {
            List<int> result = new List<int>();
            var tree1List = tree1.InOrder(tree1.Root);
            var tree2List = tree2.InOrder(tree2.Root);
            foreach (int i in tree1List)
            {
                if(tree2List.Contains(i)) result.Add(i);
                
            }
            return result;
        }
    }
}
