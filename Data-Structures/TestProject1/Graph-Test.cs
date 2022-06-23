using Data_Structures.Data_structures.graph;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class Graph_Test
    {
        [Fact]
        public void addTest()
        {
            Graph graph1 = new Graph();
            graph1.addNode('h');
            graph1.addNode('w');
            Assert.Equal('h', graph1.getNodes()[0].Value);
            Assert.Equal('w', graph1.getNodes()[1].Value);
        }
        [Fact]
        public void addEdgeTest()
        {
            Graph graph1 = new Graph();
            graph1.addNode('h');
            graph1.addNode('w');
            graph1.addNode('s');

            graph1.addEdge(graph1.getNodes()[0], graph1.getNodes()[1]);
            graph1.addEdge(graph1.getNodes()[0], graph1.getNodes()[2]);

            List<Node> neighbors = graph1.getNeighbors(graph1.getNodes()[0]);
            string nodeNeighbors = $"{neighbors[0].Value}{neighbors[1].Value}";
            Assert.Equal("ws", nodeNeighbors);

        }
        [Fact]
        public void getNodesTest()
        {
            Graph graph1 = new Graph();
            graph1.addNode('h');
            graph1.addNode('w');
            graph1.addNode('s');
            string s = $"{graph1.getNodes()[0].Value}{graph1.getNodes()[1].Value}{graph1.getNodes()[2].Value}";
            Assert.Equal("hws", s);

        }
        [Fact]
        public void returnOneTest()
        {
            Graph graph1 = new Graph();
            graph1.addNode('h');
            Assert.Equal('h', graph1.getNodes()[0].Value);

        }
        [Fact]
        public void sizeTest()
        {
            Graph graph1 = new Graph();
            graph1.addNode('h');
            graph1.addNode('w');
            graph1.addNode('s');
            Assert.Equal(3, graph1.Size());
        }
        [Fact]
        public void emptyTest()
        {
            Graph graph1 = new Graph();
            Assert.Null(graph1.getNodes());
        }
    }
}
