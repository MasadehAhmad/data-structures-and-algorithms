# Challenge Summary
Write a function called breadth first

Arguments: tree

Return: list of all values in the tree, in the order they were encountered

## Whiteboard Process
![Whiteboard](Whiteboard.png)

## Approach & Efficiency
this method take O(n) time complexity

## Solution
open the sln file and run


 

    
            
    public List<int> breadthFirst(Node root)
        {
            List<int> result = new List<int>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            while (breadth.Count > 0)
            {
                Node front = breadth.Dequeue();
                result.Add(front.Data);


                if (front.Left != null)
                    breadth.Enqueue(front.Left);

                if (front.Right != null)
                    breadth.Enqueue(front.Right);
            }

            return result;

        }
