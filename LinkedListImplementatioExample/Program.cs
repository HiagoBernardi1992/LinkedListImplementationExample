using System;

namespace LinkedListImplementatioExample
{
    public class Node
    {
        public int? Value { get; set; }
        public LinkedList? Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
    public class LinkedList
    {
        public Node root { get; set; }
        public LinkedList()
        {

        }

        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                Node toAdd = new Node(value);
                Node current = root;
                while (current.Next != null)
                {
                    current = current.Next.root;
                }

                current.Next.root = toAdd;
            }
        }

        public void AddAtPosition(int position, int value)
        {
            Node current = root;
            if (position == 1)
            {
                root.Value = value;
                root.Next.root = current;
            } else
            {
                int i = 1;
                while (i < position)
                {
                    current = current.Next.root;
                    if (current.Value == null)
                        break;
                    i++;
                }
                current.Value = value;
            }            
        }

        public void PrintAll()
        {
            var current = root;
            while (current.Value != null)
            {
                Console.WriteLine(current.Value.ToString());
                current = current.Next.root;
            }
        }

        public void PrintAtPosition(int position)
        {
            Node current = root;
            int i = 0;
            while(i < position)
            {
                if(!current.Value.HasValue)
                {
                    Console.WriteLine("Don't have any item in this position");
                    break;
                }
                current = current.Next.root;
            }
            Console.WriteLine(current.Value.ToString());
        }

        public void DeleteLast()
        {
            var current = root;
            while(current.Next != null)
            {
                current = current.Next.root;
            }
            current.Next = null;
            current.Value = null;
        }

        public void DeleteAtPosition(int position)
        {
            Node current = root;
            Node past;
            int i = 0;
            while(i < position)
            {
                if (!current.Value.HasValue)
                {
                    break;
                }
                current = current.Next.root;
            }
            current = current.Next.root;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
