using Data_Structures.Data_structures.graph;
using Data_Structures.Data_structures.graph_business_trip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class business_trip_Test
    {
        [Fact]
        public void test1()
        {
            graph_business_trip bt = new graph_business_trip();
            Graph GD = new Graph();
            Node p = GD.addNode('p');
            Node a = GD.addNode('a');
            Node m = GD.addNode('m');
            Node o = GD.addNode('o');
            Node n = GD.addNode('n');
            Node b = GD.addNode('b');
            GD.addEdge(p, a);
            GD.addEdge(a, m);
            GD.addEdge(a, o);
            GD.addEdge(m, o);
            GD.addEdge(m, n);
            GD.addEdge(m, b);
            GD.addEdge(n, b);
            GD.addEdge(o, b);
            char[] citys = new char[3] {'p','a','o'};
            Assert.Equal(2, bt.BusinessTrip(GD, citys));
            
            

        }
        [Fact]
        public void test2()
        {
            graph_business_trip bt = new graph_business_trip();
            Graph GD = new Graph();
            Node p = GD.addNode('p');
            Node a = GD.addNode('a');
            Node m = GD.addNode('m');
            Node o = GD.addNode('o');
            Node n = GD.addNode('n');
            Node b = GD.addNode('b');
            GD.addEdge(p, a);
            GD.addEdge(a, m);
            GD.addEdge(a, o);
            GD.addEdge(m, o);
            GD.addEdge(m, n);
            GD.addEdge(m, b);
            GD.addEdge(n, b);
            GD.addEdge(o, b);
            char[] citys = new char[3] { 'm', 'o', 'b' };
            Assert.Equal(2, bt.BusinessTrip(GD, citys));
        }


        }
    }
