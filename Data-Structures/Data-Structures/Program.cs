using Data_Structures.Data_structures.Array_Insert_Shift;
using Data_Structures.Data_structures.Array_Reverse;
using Data_Structures.Data_structures.Array_Binary_Search;
using System;
using Data_Structures.Data_structures.Trees.TreeFizzBuzz;
using System.Collections.Generic;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode("15");
            root.children.Add(new TreeNode("2"));
            root.children.Add(new TreeNode("3"));
            root.children.Add(new TreeNode("4"));
            root.children[0].children.Add(new TreeNode("5"));
            root.children[0].children.Add(new TreeNode("6"));
            root.children[0].children.Add(new TreeNode("7"));
            root.children[1].children.Add(new TreeNode("8"));
            root.children[2].children.Add(new TreeNode("9"));
            root.children[2].children.Add(new TreeNode("10"));
            root.children[2].children.Add(new TreeNode("11"));
            List<string> list = root.traverse(root);
            foreach(string s in list) Console.WriteLine(s);
            Console.WriteLine("");
            List<string> list2 = root.FizzBuzz(root);
            foreach (string s in list2) Console.WriteLine(s);
        }
    }
}
