using System;
class HashMap
{
    // Node for Linked List
    class Node
    {
        public int key;
        public int value;
        public Node next;
        public Node(int key, int value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
    private int capacity;
    private Node[] buckets;
    // Constructor
    public HashMap(int capacity)
    {
        this.capacity = capacity;
        buckets = new Node[capacity];
    }
    // Hash function
    private int Hash(int key)
    {
        return key % capacity;
    }
    // Insert or Update
    public void Put(int key, int value)
    {
        int index = Hash(key);
        Node head = buckets[index];
        // Update if key already exists
        Node current = head;
        while (current != null)
        {
            if (current.key == key)
            {
                current.value = value;
                return;
            }
            current = current.next;
        }
        // Insert at beginning of linked list
        Node newNode = new Node(key, value);
        newNode.next = head;
        buckets[index] = newNode;
    }
    // Retrieve value
    public int Get(int key)
    {
        int index = Hash(key);
        Node current = buckets[index];
        while (current != null)
        {
            if (current.key == key)
                return current.value;
            current = current.next;
        }
        return -1; // Key not found
    }
    // Remove key
    public void Remove(int key)
    {
        int index = Hash(key);
        Node current = buckets[index];
        Node prev = null;
        while (current != null)
        {
            if (current.key == key)
            {
                if (prev == null)
                    buckets[index] = current.next;
                else
                    prev.next = current.next;
                return;
            }
            prev = current;
            current = current.next;
        }
    }
    // Display Hash Map
    public void Display()
    {
        for (int i = 0; i < capacity; i++)
        {
            Console.Write($"Bucket {i}: ");
            Node current = buckets[i];
            while (current != null)
            {
                Console.Write($"[{current.key}:{current.value}] -> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }
}
// Testing the Hash Map
class Program
{
    public static void Main(String[] args)
    {
        HashMap map = new HashMap(5);
        map.Put(1, 10);
        map.Put(6, 20);   // Collision with key 1
        map.Put(11, 30);  // Collision again
        map.Put(2, 40);
        Console.WriteLine("Hash Map:");
        map.Display();
        Console.WriteLine("\nGet key 6: " + map.Get(6));
        Console.WriteLine("Get key 3: " + map.Get(3));
        map.Remove(6);
        Console.WriteLine("\nAfter removing key 6:");
        map.Display();
    }
}
