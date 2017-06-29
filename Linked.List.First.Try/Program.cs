using System;

namespace Linked.List.First.Try
{
    class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    class MyLinkedList
    {
        private Node Head { get; set; }
        private Node Current { get; set; }

        public void Insert(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Current = Head;
            }
            else
            {
                Current.Next = node;
                Current = node;
            }
        }

        public void Remove(Node node)
        {
            var nodeToRemove = LookUp(Head, node);
            if (nodeToRemove == null) return;
            if (nodeToRemove == Head)
            {
                Head = Head.Next;
                return;
            }
            var previous = LookUpReturnPrevious(Head, node);
            var next = nodeToRemove.Next;
            if (previous == null) return;
            previous.Next = next;
        }

        public bool Contain(Node lookupNode)
        {
            return LookUp(Head, lookupNode) != null;
        }

        private Node LookUpReturnPrevious(Node headNode, Node lookNode)
        {
            if (headNode == lookNode) return null;
            while (headNode.Next != null)
            {
                var previous = headNode;
                var next = headNode.Next;
                if (next == lookNode)
                {
                    return previous;
                }
                headNode = next;
            }
            return null;
        }

        private Node LookUp(Node headNode, Node lookupNode)
        {
            if (headNode == lookupNode) return headNode;
            if (headNode.Next == null) return null;
            return LookUp(headNode.Next, lookupNode);
        }

        public void Traverse()
        {
            Traverse(Head);
        }

        private void Traverse(Node node)
        {
            if (node == null) return;
            Console.Write(node);
            if (node.Next != null)
            {
                Console.Write("->");
            }
            else return;
            Traverse(node.Next);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.Traverse();

            var headNode = new Node()
            {
                Data = "giang"
            };
            linkedList.Insert(headNode);

            var nodeTest = new Node()
            {
                Data = 1994
            };
            linkedList.Insert(nodeTest);

            var nodeToLookUp = new Node()
            {
                Data = "thao"
            };
            linkedList.Insert(nodeToLookUp);

            var lastNode = new Node()
            {
                Data = 1992
            };
            linkedList.Insert(lastNode);

            linkedList.Traverse();

            Console.WriteLine();

            Console.WriteLine(linkedList.Contain(nodeToLookUp));
            Console.WriteLine(linkedList.Contain(new Node()
            {
                Data = "giang"
            }));

            Console.WriteLine();

            linkedList.Remove(headNode);
            linkedList.Traverse();

            Console.WriteLine();

            linkedList.Remove(lastNode);
            linkedList.Traverse();

            Console.WriteLine();

            linkedList.Remove(nodeTest);
            linkedList.Traverse();

            Console.WriteLine();

            linkedList.Remove(nodeToLookUp);
            linkedList.Traverse();

            Console.WriteLine();

            linkedList.Insert(new Node()
            {
                Data = "250694"
            });
            linkedList.Traverse();

            Console.ReadKey();
        }
    }
}
