using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash.Table.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashTable hashTable = new MyHashTable(10);
            hashTable.Insert(1, "a");
            hashTable.Insert(2, "b");
            hashTable.Insert(3, "c");
            hashTable.Insert(4, "d");
            hashTable.Insert(5, "e");
            hashTable.Insert(11, "A");
            hashTable.Insert(12, "B");
            hashTable.Insert(13, "C");
            hashTable.Insert(14, "D");
            hashTable.Insert(15, "E");
            Console.WriteLine(hashTable.Get(5)?.Data);
            var test = hashTable.TestData();
            Console.ReadKey();
        }
    }
}
