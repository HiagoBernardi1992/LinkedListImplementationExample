using System;

namespace LinkedListImplementatioExample
{
    
    public class LinkedList
    {
        public int Value { get; set; }
        public LinkedList Next { get; set; }
        private LinkedList()
        {

        }
        public LinkedList(int value)
        {
            Value = value;
        }

        public void Add(int value)
        {
            var newNode = new LinkedList(value);
            if (Next == null)
            {
                Next = newNode;
            }
            else
            {
                var current = Next;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }


        public void PrintAll()
        {
            Console.WriteLine(Value);
            var current = Next;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public void PrintAtPosition(int position)
        {
            if(position <= 1)
                Console.WriteLine(Value.ToString());
            else
            {
                var current = Next;
                int i = 0;
                while (i < position)
                {
                    if(current.Next == null)
                    {
                        break;
                    }
                    current = current.Next;
                    i++;
                }
                Console.WriteLine(current.Value.ToString());
            }
        }

        public void DeleteLast()
        {
            var current = this;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current = new LinkedList();
        }

        public void DeleteAtPosition(int position)
        {
            int i = 0;
            var current = this;
            while (i < position)
            {
                if (this.Next == null)
                {
                    break;
                }
                current = current.Next;
                i++;
            }
            current = new LinkedList();
        }

        public void Reverse()
        {
            if (this == null || this.Next == null)
                return;

            //example 1, 2, 3, 4, 5
            var head = this;
            var first = head;
            var second = head.Next;
            while (second != null)
            {
                var temp = second.Next;
                //here comes the reverse
                //pass the first node to be the second            
                second.Next = first;
                //pass the second to firts to interate
                first = second;
                // and the second to be the third
                second = temp;
            }
            head.Next = null;
            head = first;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList head = new LinkedList(10);
            head.Add(11);
            head.PrintAtPosition(1);
            head.Add(12);
            head.Add(13);
            head.Add(14);
            head.PrintAtPosition(4);
            head.PrintAtPosition(100); // it will return the last item
            head.PrintAll();
        }
    }
}
