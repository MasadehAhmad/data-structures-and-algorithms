# Trees
A Binary Search Tree (BST) is a type of tree that does have some structure attached to it. In a BST, nodes are organized in a manner where all values that are smaller than the root are placed to the left, and all values that are larger than the root are placed to the right.

## Challenge
1. Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.

2. Create a Binary Tree class
    - Define a method for each of the depth first traversals:
        - pre order
        - in order
        - post order which returns an array of the values, ordered appropriately.

3. Create a Binary Search Tree class
    - This class should be a sub-class (or your languages equivalent) of the Binary Tree Class, with the following additional methods:
        - Add
            - Arguments: value
            - Return: nothing
            - Adds a new node with that value in the correct location in the binary search tree.
        - Contains
            - Argument: value
            - Returns: boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency
- Pre Order O(n) time and space
- In Order O(n) time and space
- Post Order O(n) time and space
- Add O(n) Time and O(1) space
- Contains O(n) time 

## API
1. Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.

2. Create a Binary Tree class
    - Define a method for each of the depth first traversals:
        - pre order
        - in order
        - post order which returns an array of the values, ordered appropriately.

3. Create a Binary Search Tree class
    - This class should be a sub-class (or your languages equivalent) of the Binary Tree Class, with the following additional methods:
        - Add
            - Arguments: value
            - Return: nothing
            - Adds a new node with that value in the correct location in the binary search tree.
        - Contains
            - Argument: value
            - Returns: boolean indicating whether or not the value is in the tree at least once.
