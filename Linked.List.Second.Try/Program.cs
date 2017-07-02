using System;

namespace Linked.List.Second.Try
{
    internal class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    internal class MyLinkedList
    {
        private Node Head { get; set; }
        private Node Last { get; set; }

        public void Insert(object data)
        {
            var newNode = new Node
            {
                Data = data,
                Next = null
            };
            if (Head == null)
            {
                Head = newNode;
                Last = Head;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
        }

        public Node FindFirst(object lookupData)
        {
            if (Head.Data.Equals(lookupData)) return Head;
            var next = Head.Next;
            do
            {
                if (next.Data.Equals(lookupData))
                    return next;
                next = next.Next;
            } while (next != null);
            return null;
        }

        public void Traverse()
        {
            Traverse(Head);
        }

        public static void Traverse(Node node)
        {
            if (node == null) return;
            Console.Write(node);
            if (node.Next != null)
                Console.Write("->");
            else return;
            Traverse(node.Next);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var linkedList = new MyLinkedList();

            const string giang = "giang";
            const string thao = "thao";
            const int num1994 = 1994;
            const string num1992 = "1992";
            var person = new
            {
                Name = "Khuong",
                Age = 60
            };

            linkedList.Insert(giang);
            linkedList.Insert(num1994);
            linkedList.Insert(person);
            linkedList.Insert(thao);
            linkedList.Insert(num1992);
            linkedList.Insert("testSearch");

            linkedList.Traverse();

            Console.WriteLine();

            var giangNode = linkedList.FindFirst(giang);
            Console.WriteLine(giangNode);
            var thaoNode = linkedList.FindFirst(thao);
            Console.WriteLine(thaoNode);
            Console.WriteLine(person);
            Console.WriteLine(linkedList.FindFirst("noRecord"));
            Console.WriteLine(linkedList.FindFirst("testSearch"));

            MyLinkedList.Traverse(thaoNode);

            Console.WriteLine();

            MyLinkedList.Traverse(giangNode.Next);

            Console.WriteLine();
            Console.WriteLine(linkedList.FindFirst(num1994));

            Console.ReadKey();
        }
    }
}