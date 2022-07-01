using Data_Structures.Data_structures.graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.graph_depth_first
{
    public class GraphDepthFirst : Graph
    {
        public GraphDepthFirst() : base() { }
        public List<char> DepthFirst(Node root)
        {
            List<char> result = new List<char>();
            Stack<Node> stack = new Stack<Node>();
            List<Node> visted = new List<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                Node node = stack.Pop();    
                if (!result.Contains(node.Value))
                {
                    result.Add(node.Value);
                }
                visted.Add(node);
                foreach(Node neighbor in node.Neighbors)
                {
                    if (!visted.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                    
                }
            }
            return result;
        }
    }
}
