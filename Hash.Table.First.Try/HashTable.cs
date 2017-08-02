using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash.Table.First.Try
{
    public class MyHashTable
    {
        private readonly int _buffer;
        private readonly MyLinkedList[] _data;

        public MyHashTable(int buffer)
        {
            _buffer = buffer;
            _data = new MyLinkedList[_buffer];
            for (int i = 0; i < _buffer; i++)
            {
                _data[i] = new MyLinkedList();
            }
        }

        private int Hash(int key)
        {
            return key % _buffer;
        }

        public void Insert(int key, object data)
        {
            int hash = Hash(key);
            _data[hash].Insert(key, data);
        }

        public Node Get(int key)
        {
            int hash = Hash(key);
            return _data[hash].Find(key);
        }

        public MyLinkedList[] TestData()
        {
            return _data;
        }
    }

    public class Node
    {
        public int Key { get; }
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(int key, object data)
        {
            Key = key;
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class MyLinkedList
    {
        private Node Head { get; set; }
        private Node Last { get; set; }

        public void Insert(int key, object data)
        {
            var newNode = new Node(key, data);
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

        public Node Find(int key)
        {
            return Find(Head, key);
        }

        private Node Find(Node node, int key)
        {
            if (node.Key == key)
            {
                return node;
            }
            if (node.Next == null) return null;
            return Find(node.Next, key);
        }

    }
}
