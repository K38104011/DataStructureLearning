using System;
using System.Linq;

namespace Dijkstra.Shortet.Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var dijkstra = new Dijkstra(new[,]
            {
                {0, 4, 0, 0, 0, 0, 0, 8, 0},
                {4, 0, 8, 0, 0, 0, 0, 11, 0},
                {0, 8, 0, 7, 0, 4, 0, 0, 2},
                {0, 0, 7, 0, 9, 14, 0, 0, 0},
                {0, 0, 0, 9, 0, 10, 0, 0, 0},
                {0, 0, 4, 14, 10, 0, 2, 0, 0},
                {0, 0, 0, 0, 0, 2, 0, 1, 6},
                {8, 11, 0, 0, 0, 0, 1, 0, 7},
                {0, 0, 2, 0, 0, 0, 6, 7, 0}
            });
            var result = dijkstra.FindShortestPath();
            var index = 0;
            foreach (var distanceVertex in result)
            {
                Console.WriteLine(string.Format("Vertex: {0} \tDistance from Source: {1}", index++, distanceVertex));
            }
            Console.WriteLine();
            dijkstra.IsSingleTarget = true;
            for (var i = 0; i < 9; i++)
            {
                dijkstra.TargetVertex = i;
                Console.WriteLine(string.Format("Vertex: {0} \tDistance from Source: {1}", i, dijkstra.FindShortestPath().First()));
            }
            Console.ReadKey();
        }
    }
}
