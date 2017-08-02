using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.Binary.Tree.First.Try
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
        public static void Swap(ref Node node1, ref Node node2)
        {
            var tempKey = node1.Key;
            var tempData = node1.Data;
            node1 = new Node(node2.Key, node2.Data);
            node2 = new Node(tempKey, tempData);
        }

        public override string ToString()
        {
            return Key + ":" + Data;
        }
    }

    public class MyHeapBinaryTree
    {
        private Node[] _data;
        private int _buffer = 100;
        private int _currentIndex = -1;
        public MyHeapBinaryTree()
        {
            _data = new Node[_buffer];
        }

        public void Insert(int key, object data)
        {
            _data[++_currentIndex] = new Node(key, data);
            Heapify(_currentIndex);
        }

        private void Heapify(int currentIndex)
        {
            int parentIndex;
            if (currentIndex == 0) return;
            do
            {
                parentIndex = GetParentIndex(currentIndex);
                if (parentIndex < 0) break;
                if (_data[parentIndex].Key > _data[currentIndex].Key)
                {
                    Node.Swap(ref _data[parentIndex], ref _data[currentIndex]);
                }
                currentIndex = parentIndex;
            } while (parentIndex > 0);
        }

        private int GetParentIndex(int childIndex)
        {
            return (childIndex + 1) / 2 - 1;
        }

        public void Traverse()
        {
            string s = string.Join(", ", _data.AsEnumerable().Where(node => node != null));
            Console.WriteLine(s);
        }
    }
}
