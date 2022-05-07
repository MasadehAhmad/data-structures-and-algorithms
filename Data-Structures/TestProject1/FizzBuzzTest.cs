using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.Trees.TreeFizzBuzz;
using Xunit;

namespace TestProject1
{
    public class FizzBuzzTest
    {
        [Fact]
        public void test()
        {
            TreeNode root = new TreeNode("15");
            root.children.Add(new TreeNode("2"));
            root.children.Add(new TreeNode("3"));
            root.children.Add(new TreeNode("4"));
            root.children[0].children.Add(new TreeNode("5"));
            root.children[0].children.Add(new TreeNode("6"));
            root.children[0].children.Add(new TreeNode("7"));
 
            List<string> list = root.FizzBuzz(root);
            List<string> list2 = new List<string> { "FizzBuzz", "2", "Fizz","4","Buzz","Fizz","7"};
            Assert.Equal(list, list2);
        }
       
      
    }
}
