# Challenge Summary
Write the following method for the Graph class:

- breadth first
- Arguments: Node
- Return: A collection of nodes in the order they were visited.
- Display the collection

## Whiteboard Process
![](./Whiteboard.png)

## Approach & Efficiency
Time Complexity: O(V+E), where V is the number of nodes and E is the number of edges.

Space Complexity: O(V)

## Solution
```
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
```