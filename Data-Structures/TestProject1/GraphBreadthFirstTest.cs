using Data_Structures.Data_structures.graph;
using Data_Structures.Data_structures.graph_breadth_first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace TestProject1
{
    public class GraphBreadthFirstTest
    {
        [Fact]
        public void Test()
        {
            GraphBreadthFirst GD = new GraphBreadthFirst();
            Node p = GD.addNode('p');
            Node a = GD.addNode('a');
            Node m = GD.addNode('m');
            Node o = GD.addNode('o');
            Node n = GD.addNode('n');
            Node b = GD.addNode('b');
            GD.addEdge(p,a);
            GD.addEdge(a,m);
            GD.addEdge(a,o);
            GD.addEdge(m,o);
            GD.addEdge(m, n);
            GD.addEdge(m,b);
            GD.addEdge(n,b);
            GD.addEdge(o,b);
            string output = "";
            
            List<Node> BFS = GD.breadthFirst();
            foreach(Node node in BFS)
            {
                output += $"{node.Value}";
            }
            Assert.Equal("pamonb", output);

        }
    }
}
