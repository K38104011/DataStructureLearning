using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue(100);

            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine(queue.Size());

            queue.Traverse();

            Console.ReadKey();
        }
    }
}
