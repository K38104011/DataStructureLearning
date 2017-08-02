using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinarySearchTree binarySearchTree = new MyBinarySearchTree();
            binarySearchTree.Insert(100, "a");
            binarySearchTree.Insert(20, "b");
            binarySearchTree.Insert(500, "c");
            binarySearchTree.Insert(10, "d");
            binarySearchTree.Insert(30, "e");
            binarySearchTree.Insert(40, "f");
            Console.WriteLine(binarySearchTree.Search(100)?.Data);
            Console.ReadKey();
        }
    }
}
