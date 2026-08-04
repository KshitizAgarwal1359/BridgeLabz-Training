//Pre Order Traversal: Root->Left->Right
using System;
class Node
{
    public int Data;
    public Node Left;
    public Node Right;
    public Node(int data)
    {
        Data=data;
        Left=null;
        Right=null;
    }
}
class BinaryTree
{
    public Node Root;
    public BinaryTree()
    {
        Root=null;
    }
    public void PreOrder(Node node)
    {
        if(node==null)
        return;
        Console.Write(node.Data+" ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }
}
class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.Root=new Node(1);
        tree.Root.Left=new Node(2);
        tree.Root.Right=new Node(3);
        tree.Root.Left.Left= new Node(4);
        tree.Root.Left.Right= new Node(5);
        tree.Root.Right.Left=new Node(6);
        tree.Root.Right.Right = new Node(7);
        Console.WriteLine("PreOrder Traversal: ");
        tree.PreOrder(tree.Root);
    }
}