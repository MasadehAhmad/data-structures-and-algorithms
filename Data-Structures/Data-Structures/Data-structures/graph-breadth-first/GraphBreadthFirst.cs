using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structures.Data_structures.graph;
namespace Data_Structures.Data_structures.graph_breadth_first
{
    public class GraphBreadthFirst :  Graph
    {
        public GraphBreadthFirst() : base()
        {
            
        }
        public List<Node> breadthFirst()
        {
            List<Node> nodes = new List<Node>();
            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visited = new HashSet<Node>();
            queue.Enqueue(this.getNodes().First());
            visited.Add(this.getNodes().First());
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                nodes.Add(node);
                foreach(var child in node.Neighbors)
                {
                    if (!(visited.Contains(child)))
                    {
                        visited.Add(child);
                        queue.Enqueue(child);
                    }
                }
            }
            return nodes;
        }
    }
}
