## Graphs
A graph is a non-linear data structure that can be looked at as a collection of vertices (or nodes) potentially connected by line segments named edges.

Here is some common terminology used when working with Graphs:

1. Vertex - A vertex, also called a “node”, is a data object that can have zero or more adjacent vertices.
2. Edge - An edge is a connection between two nodes.
3. Neighbor - The neighbors of a node are its adjacent nodes, i.e., are connected via an edge.
4. Degree - The degree of a vertex is the number of edges connected to that vertex.

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list

## Approach & Efficiency
Add node takes O(1) for time and space
Add edge takes O(1) for time and space
Get nodes takes O(n) for time and O(1) for space
Get neighbors O(n) for time and O(1) for space
Size takes O(1) for time and space
## API
- Add node

Arguments: value
Returns: The added node
Add a node to the graph

- Add edge

Arguments: 2 nodes to be connected by the edge, weight (optional)
Returns: nothing
Adds a new edge between two nodes in the graph
If specified, assign a weight to the edge
Both nodes should already be in the Graph

- Get nodes

Arguments: none
Returns all of the nodes in the graph as a collection (set, list, or similar)

- Get neighbors

Arguments: node
Returns a collection of edges connected to the given node
Include the weight of the connection in the returned collection

- Size

Arguments: none
Returns the total number of nodes in the graph