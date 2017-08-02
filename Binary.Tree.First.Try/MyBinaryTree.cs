using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary.Tree.First.Try
{
    public class Node
    {
        public object Data { get; }

        public Node(object data)
        {
            Data = data;
        }

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }

    public class MyBinaryTree
    {
        public Node Root { get; set; }

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
