using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.graph
{
    public class Node
    {
        public char Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(char input)
        {
            Value = input;
            Neighbors = new List<Node>();
        }
    }
    public class graph
    {
        LinkedList<Node> Nodes { get; set; }
        
        public graph()
        {
            Nodes = new LinkedList<Node>();
        }
        public void addNode(char value)
        {
            Nodes.AddLast(new Node(value));
        }
        public void addEdge(Node node1, Node node2)
        {
            node1.Neighbors.Add(node2);
            node2.Neighbors.Add(node1);
        }
        public List<Node> getNodes()
        {
            if(Nodes.Count==0) return null;
            return Nodes.ToList();
        }
        public List<Node> getNeighbors(Node node)
        {
            return node.Neighbors;
        }
        public int Size()
        {
            return Nodes.Count;
        }
    }
}
