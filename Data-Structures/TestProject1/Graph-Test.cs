using Data_Structures.Data_structures.graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class Graph_Test
    {
        [Fact]
        public void addTest()
        {
            graph graph1 = new graph();
            graph1.addNode('h');
            graph1.addNode('w');
            Assert.Equal('h',graph1.getNodes()[0].Value);
            Assert.Equal('w', graph1.getNodes()[1].Value);
        }
        [Fact]
        public void addEdgeTest()
        {
            graph graph1 = new graph();
            graph1.addNode('h');
            graph1.addNode('w');
            graph1.addNode('s');

            graph1.addEdge(graph1.getNodes()[0], graph1.getNodes()[1]);
            graph1.addEdge(graph1.getNodes()[0], graph1.getNodes()[2]);

            List<Node> neighbors = graph1.getNeighbors(graph1.getNodes()[0]);
            string nodeNeighbors = $"{neighbors[0].Value}{neighbors[1].Value}";
            Assert.Equal("ws", nodeNeighbors) ;

        }
        [Fact]
        public void getNodesTest()
        {
            graph graph1 = new graph();
            graph1.addNode('h');
            graph1.addNode('w');
            graph1.addNode('s');
            string s = $"{graph1.getNodes()[0].Value}{graph1.getNodes()[1].Value}{graph1.getNodes()[2].Value}";
            Assert.Equal("hws", s);

        }
        [Fact]
        public void returnOneTest()
        {
            graph graph1 = new graph();
            graph1.addNode('h');
            Assert.Equal('h', graph1.getNodes()[0].Value);

        }
        [Fact]
        public void sizeTest() 
        {
            graph graph1 = new graph();
            graph1.addNode('h');
            graph1.addNode('w');
            graph1.addNode('s');
            Assert.Equal(3,graph1.Size());
        }
        [Fact]
        public void emptyTest()
        {
            graph graph1 = new graph();
            Assert.Null(graph1.getNodes());
        }
    }
}
