using System;

namespace Hash.Table.Open.Addressing.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashTable hashTable = new MyHashTable();
            hashTable.Insert(1, "v1");
            hashTable.Insert(11, "v2");
            hashTable.Insert(21, "v3");
            Console.WriteLine(hashTable.Search(11));
            hashTable.Delete(11);
            Console.WriteLine(hashTable.Search(11));
            Console.WriteLine(hashTable.Search(21));
            hashTable.Insert(11, "v4");
            Console.WriteLine(hashTable.Search(11));
            Console.ReadKey();
        }
    }
}
