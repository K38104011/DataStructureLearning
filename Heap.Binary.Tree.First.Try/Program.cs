using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.Binary.Tree.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHeapBinaryTree heapBinaryTree = new MyHeapBinaryTree();
            heapBinaryTree.Insert(3, "a");
            heapBinaryTree.Insert(10, "b");
            heapBinaryTree.Insert(11, "c");
            heapBinaryTree.Insert(5, "d");
            heapBinaryTree.Insert(15, "e");
            heapBinaryTree.Insert(17, "f");
            heapBinaryTree.Insert(13, "g");
            heapBinaryTree.Insert(12, "h");
            heapBinaryTree.Insert(11, "i");
            heapBinaryTree.Insert(8, "j");
            heapBinaryTree.Insert(21, "k");
            heapBinaryTree.Traverse();
            Console.WriteLine(heapBinaryTree.ExtractMin());
            heapBinaryTree.Traverse();
            Console.WriteLine(heapBinaryTree.ExtractMin());
            heapBinaryTree.Traverse();
            Console.ReadKey();
        }
    }
}
