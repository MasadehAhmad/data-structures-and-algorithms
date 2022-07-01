# Depth First Traversal
In a breadth first traversal, you are starting at a specific vertex/node. This node must be specified when calling the BreadthFirst() method. The breadth first traversal of a graph is like that of a tree, with the exception that graphs can have cycles. Traversing a graph that has cycles will result in an infinite loop….this is bad. To prevent such behavior, we need to have some way to keep track of whether a vertex has been “visited” before. Upon each visit, we’ll add the previously-unvisited vertex to a visited set, so we know not to visit it again as traversal continues.

## Challenge
Write the following method for the Graph class:

- Name: Depth first
- Arguments: Node (Starting point of search)
- Return: A collection of nodes in their pre-order depth-first traversal order
- Program output: Display the collection

## Approach & Efficiency
Time complexity: O(V + E), where V is the number of vertices and E is the number of edges in the graph.
Space Complexity: O(V), since an extra visited array of size V is required.

## Solution
```
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
```