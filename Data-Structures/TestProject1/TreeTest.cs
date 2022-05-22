using Data_Structures.Data_structures.Trees;
using Xunit;

namespace TestProject1
{
    public class TreeTest
    {
        [Fact]
        public void emptyTree()
        {
            BinaryTree tree = new BinaryTree();
            Assert.Null(tree.Root);
        }
        [Fact]
        public void singleRootNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(5);
            Assert.NotNull(tree.Root);
            Assert.Null(tree.Root.Left);
            Assert.Null(tree.Root.Right);
        }
        [Fact]
        public void binarySearchTreeAdd()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(12);
            tree.Add(3);
            Assert.Equal(5, tree.Root.Data);
            Assert.Equal(3, tree.Root.Left.Data);
            Assert.Equal(12, tree.Root.Right.Data);
        }
        [Fact]
        public void inOrderTest()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(12);
            tree.Add(2);
            int[] list = { 2, 5, 12 };
            list[0] = 2;
            list[1] = 5;
            list[2] = 12;
            Assert.Equal(list, tree.InOrder(tree.Root));

        }
        [Fact]
        public void preOrderTest()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(12);
            tree.Add(2);
            int[] list = { 5, 2, 12 };
            list[0] = 5;
            list[1] = 2;
            list[2] = 12;
            Assert.Equal(list, tree.PreOrder(tree.Root));
        }
        [Fact]
        public void postOrderTest()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(12);
            tree.Add(2);
            int[] list = { 2, 12, 5 };
            Assert.Equal(list, tree.PostOrder(tree.Root));
        }
        [Fact]
        public void containsTest()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(5);
            tree.Add(12);
            tree.Add(2);
            tree.Add(1);
            tree.Add(2);
            tree.Add(10);
            Assert.True(tree.contains(10));
            Assert.False(tree.contains(6));

        }

        [Fact]
        public void MaxTreeTest()
        {
            TreeMax tree = new TreeMax();
            tree.Add(5);
            tree.Add(2);
            tree.Add(12);
            tree.Add(1);
            tree.Add(2);
            tree.Add(10);
            Assert.Equal(12, tree.GetMax());
            Assert.NotEqual(10, tree.GetMax());
        }

        [Fact]
        public void BFTest()
        {
            TreeBreadthFirst tree = new TreeBreadthFirst();
            tree.Add(5);
            tree.Add(2);
            tree.Add(12);
            tree.Add(1);
            tree.Add(2);
            tree.Add(10);
            int[] arr = { 5,2,12,1,2,10};
            Assert.Equal(arr, tree.breadthFirst(tree.Root));
            
        }
    }
}
