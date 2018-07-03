using System;

namespace Node.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This code below add 3 nodes");
            var First = new Node { Value = 1 };
            var Second = new Node { Value = 2 };
            var Third = new Node { Value = 3 };

            Console.WriteLine("Node1:\t " + First.Value);
            Console.WriteLine("Node2:\t " + Second.Value);
            Console.WriteLine("Node3: \t " + Third.Value);
            //Adding now nod to next node 
            First.Next = Second;
            Second.Next = Third;
            Console.WriteLine("Node to Next Node is LinkedList");
            Console.WriteLine("Node1: " + First.Value + "\t NextNode" +First.Next.Value);
            Console.WriteLine("Node2: " + Second+ "\t NextNode"+Second.Next.Value);
            Console.WriteLine("Node3: " + Third.Value);


            Console.ReadKey();
            Console.WriteLine("Thanks for the time! cheer up! ");
        }
    }
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
