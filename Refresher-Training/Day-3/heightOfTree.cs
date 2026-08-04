


using System;
class Node
{
    public int Data;
    public Node Left;
    public Node Right;
    public Node(int data)
    {
        Data = data;
        Left= null;
        Right = null;
    }
}
class BinaryTree
{
    public Node Root;
    public BinaryTree()
    {
        Root=null;
    }
    public int Height(Node node)
    {
        if (node == null)
        {
            return -1;
        }
        int leftHeight = Height(node.Left);
        int rightHeight = Height(node.Right);
        return Math.Max(leftHeight,rightHeight)+1;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        BinaryTree tree =  new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);
        tree.Root.Left.Left.Left = new Node(6);
        tree.Root.Left.Left.Right = new Node(7);
        tree.Root.Right.Left = new Node(8);
        tree.Root.Right.Right = new Node(9);
        Console.WriteLine("Tree Height: "+tree.Height(tree.Root));
    }
}
