using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures.Data_structures.Trees.TreeFizzBuzz
{
    public class TreeNode
    {
        public string value { get; set; }
        public List<TreeNode> children { get; set; }
        public TreeNode(string data)
        {
            value = data;
            children = new List<TreeNode>();
        }
                              
        public TreeNode(string data, List<TreeNode> child)
        {
            value = data;
            children = child;
        }
        public List<string> FizzBuzz(TreeNode root)
        {
            List<string> list = new List<string>();
            if (root == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int len = queue.Count();
                for (int i = 0; i < len; i++)
                {
                    int value = Convert.ToInt32(queue.First().value);
                    if (value % 15 == 0)
                    {
                        list.Add("FizzBuzz");

                    }
                    else if (value % 3 == 0)
                    {
                        list.Add("Fizz");
                    }

                    else if (value % 5 == 0)
                        list.Add("Buzz");
                    else list.Add(queue.First().value);
                    TreeNode node = queue.Dequeue();
                    foreach (TreeNode item in node.children)
                    {
                        queue.Enqueue(item);
                    }

                }

            }
            return list;

        }
        public List<string> traverse(TreeNode root)
        {
            List<string> list = new List<string>();
            if (root == null) return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int len = queue.Count();
                for (int i = 0; i < len; i++)
                {
                    TreeNode node = queue.Dequeue();
                    list.Add(node.value);
                    foreach (TreeNode item in node.children)
                    {
                        queue.Enqueue(item);
                    }

                }
            }
            return list;
        }
    }
}
