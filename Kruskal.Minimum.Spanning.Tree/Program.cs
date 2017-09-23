using System;

namespace Kruskal.Minimum.Spanning.Tree
{
    class Program
    {
        static void Main()
        {
            var kruskal = new Kruskal(new[,]
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
            kruskal.PrintSortedEdges();
            foreach (var edge in kruskal.SpanningTree)
            {
                Console.WriteLine(string.Format("{0} -- {1}", edge.Source, edge.Destination));
            }
            Console.ReadKey();
        }
    }
}
