
using Data_Structures.Data_structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Data_Structures.Data_structures.tree_intersection;

namespace TestProject1
{
    public class tree_intersection_Test
    {
        [Fact]
        public void Test()
        {
            TreeIntersection intersection = new TreeIntersection();
            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.Add(150);
            tree1.Add(100);
            tree1.Add(250);
            tree1.Add(75);
            tree1.Add(160);
            tree1.Add(200);
            tree1.Add(350);
            tree1.Add(125);
            tree1.Add(175);
            tree1.Add(300);
            tree1.Add(500);
            BinarySearchTree tree2 = new BinarySearchTree();
            tree2.Add(42);
            tree2.Add(100);
            tree2.Add(600);
            tree2.Add(15);
            tree2.Add(160);
            tree2.Add(200);
            tree2.Add(350);
            tree2.Add(125);
            tree2.Add(175);
            tree2.Add(4);
            tree2.Add(500);

            List<int> list = new List<int> { 100, 125, 160, 175, 200, 350, 500 };
            Assert.Equal(list, intersection.Intersection(tree1,tree2));
        }
        
        
    }
}
