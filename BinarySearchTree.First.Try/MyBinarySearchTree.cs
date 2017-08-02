using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.First.Try
{
    public class Node
    {
        public int Key { get; }
        public object Data { get; }
        public Node(int key, object data)
        {
            Key = key;
            Data = data;
        }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }

    public class MyBinarySearchTree
    {
        public Node Root { get; set; }

        public void Insert(int key, object data)
        {
            if (Root == null)
            {
                Root = new Node(key, data);
                return;
            }
            Insert(Root, key, data);
        }

        public void Insert(Node node, int key, object data)
        {
            if (key < node.Key)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new Node(key, data);
                }
                else
                {
                    Insert(node.LeftChild, key, data);
                }
            }
            else if (key > node.Key)
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new Node(key, data);
                }
                else
                {
                    Insert(node.RightChild, key, data);
                }
            }
            else
            {
                throw new ArgumentException("Key Duplicate!");
            }
        }

        public Node Search(int key)
        {
            return Search(Root, key);
        }

        private Node Search(Node node, int key)
        {
            if (node.Key == key)
            {
                return node;
            }
            if (key < node.Key)
            {
                if (node.LeftChild == null) return null;
                return Search(node.LeftChild, key);
            }
            if (node.RightChild == null) return null;
            return Search(node.RightChild, key);
        }

        public void Traverse()
        {
            Traverse(Root);
        }

        private void Traverse(Node root, string level = "")
        {
            if (root == null)
            {
                Console.WriteLine(level + "null");
                return;
            }
            Console.WriteLine(level + root.Data);
            level += "-";
            Traverse(root.LeftChild, level);
            Traverse(root.RightChild, level);
        }
    }
}
