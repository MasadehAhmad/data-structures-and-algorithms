using Data_Structures.Data_structures.graph;
using Data_Structures.Data_structures.graph_depth_first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class graph_depth_first_Test
    {
        [Fact]
        public void Test()
        {
            GraphDepthFirst GD = new GraphDepthFirst();
            Node a = GD.addNode('a');
            Node b = GD.addNode('b');
            Node c = GD.addNode('c');
            Node d = GD.addNode('d');
            Node e = GD.addNode('e');
            Node f = GD.addNode('f');
            Node g = GD.addNode('g');
            Node h = GD.addNode('h');

            GD.addEdge(a, d);
            GD.addEdge(a, b);
            GD.addEdge(b, d);
            GD.addEdge(b, c);
            GD.addEdge(c, g);
            GD.addEdge(d, f);
            GD.addEdge(d, h);
            GD.addEdge(d, e);
            GD.addEdge(f, h);
            List<char> DFS = new List<char>() { 'a', 'b', 'c', 'g', 'd', 'e', 'h', 'f' };
            Assert.Equal(DFS, GD.DepthFirst(a));
        }
    }
}
