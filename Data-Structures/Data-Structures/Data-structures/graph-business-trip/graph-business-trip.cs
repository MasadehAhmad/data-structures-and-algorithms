using Data_Structures.Data_structures.graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.graph_business_trip
{
    public class graph_business_trip
    {
        public int? BusinessTrip(Graph graph, char[] arr)
        {
            if (arr == null || graph == null || arr.Length == 1) { return null; }
            List<Node> nodes = graph.getNodes();
            Node vertex = nodes.FirstOrDefault(x => x.Value == arr[0]);
            if (vertex == null)
            {
                return null;
            }

            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Node current = nodes.FirstOrDefault(x => x.Value == arr[i]);
                Node next = nodes.FirstOrDefault(x => x.Value == arr[i+1]);
                if (current == null || next == null) { return null; }
                
                if (current.Neighbors.Contains(next))
                {
                    sum++; 
                }
                else
                {
                    return null;
                }
            }
            return sum;
        }
    }
}
