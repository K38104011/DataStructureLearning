using System;

namespace Hash.Table.Open.Addressing.First.Try
{
    public class MyNode
    {
        public int Key { get; set; }
        public object Data { get; set; }
        public override string ToString()
        {
            return string.Format("Key: {0}, Value: {1}", Key, Data);
        }
    }

    public class MyHashTable
    {
        private readonly MyNode[] _data;
        private Action _action;

        public MyHashTable(int bufferSize = 10)
        {
            _data = new MyNode[bufferSize];
        }

        public void Insert(int key, object value)
        {
            var node = new MyNode
            {
                Key = key,
                Data = value
            };
            var index = Hash(node.Key);
            if (_data[index] == null)
            {
                _data[index] = node;
                return;
            }
            var i = 1;
            while (_data[index] != null && index < _data.Length)
            {
                index = (node.Key + i) % _data.Length;
                if (_data[index] == null)
                {
                    _data[index] = node;
                    return;
                }
                i++;
            }
        }

        public MyNode Search(int key)
        {
            var index = Hash(key);
            if (_data[index].Key == key)
            {
                return _data[index];
            }
            var i = 1;
            while (_data[index] != null && index < _data.Length)
            {
                index = (key + i) % _data.Length;
                if (_data[index] == null)
                {
                    continue;
                }
                if (_data[index].Key == key && _data[index].Data != null)
                {
                    return _data[index];
                }
                i++;
            }
            return null;
        }

        public void Delete(int key)
        {
            var index = Hash(key);
            if (_data[index].Key == key)
            {
                _data[index].Data = null;
                return;
            }
            var i = 1;
            while (_data[index] != null && index < _data.Length)
            {
                index = (key + i) % _data.Length;
                if (_data[index].Key == key)
                {
                    _data[index].Data = null;
                    return;
                }
                i++;
            }
        }

        private int Hash(int key)
        {
            return key % _data.Length;
        }
    }
}
