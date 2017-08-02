using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary.Tree.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree binaryTree = new MyBinaryTree();
            binaryTree.Root = new Node(1);
            binaryTree.Root.LeftChild = new Node(2);
            binaryTree.Root.RightChild = new Node(3);

            var leftChildLevel1 = binaryTree.Root.LeftChild;
            leftChildLevel1.LeftChild = new Node(4);
            leftChildLevel1.RightChild = new Node(5);

            var rightChildLevel1 = binaryTree.Root.RightChild;
            rightChildLevel1.LeftChild = new Node(6);
            rightChildLevel1.RightChild = new Node(7);

            var leftleftChildLevel2 = leftChildLevel1.LeftChild;
            leftleftChildLevel2.LeftChild = new Node(8);

            var rightrightChildLevel2 = rightChildLevel1.RightChild;
            rightrightChildLevel2.RightChild = new Node(9);

            binaryTree.Traverse();

            Console.ReadKey();
        }
    }
}
