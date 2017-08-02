using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth.First.Search.First.Try
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] graph = new int[][]
            {
                new []{ 0, 1, 1, 0, 0, 0 },
                new []{ 1, 0, 0, 1, 1, 0 },
                new []{ 1, 0, 0, 0, 1, 0 },
                new []{ 0, 1, 0, 0, 1, 1 },
                new []{ 0, 1, 1, 1, 0, 0 },
                new []{ 0, 0, 0, 1, 1, 0 }
            };
            MyBreadthFirstSearch bfs = new MyBreadthFirstSearch(graph);
            bfs.Traverse();
            Console.ReadKey();
        }
    }
}
