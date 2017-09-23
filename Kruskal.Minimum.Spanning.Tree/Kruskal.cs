using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kruskal.Minimum.Spanning.Tree
{
    public class Kruskal
    {
        private readonly int[,] _graph;
        private readonly ICollection<KeyValuePair<int, Edge>> _sortedEdges;
        private readonly int[] _vertices;
        public readonly ICollection<Edge> SpanningTree;
        public int Size { get; }

        public class Edge
        {
            public int Source { get; set; }
            public int Destination { get; set; }
        }

        public Kruskal(int[,] graph)
        {
            _graph = graph;
            Size = _graph.GetLength(0);
            _sortedEdges = InitializeSortedEdge();
            _vertices = Enumerable.Repeat(-1, Size).ToArray();
            SpanningTree = new List<Edge>();
            BuildSpanningTree();
        }

        private ICollection<KeyValuePair<int, Edge>> InitializeSortedEdge()
        {
            var sortedEdges = new List<KeyValuePair<int, Edge>>();
            for (var i = 0; i < Size; i++)
            {
                for (var j = 0; j < Size; j++)
                {
                    if (_graph[i, j] > 0)
                    {
                        _graph[j, i] = 0;
                        sortedEdges.Add(new KeyValuePair<int, Edge>(_graph[i, j], new Edge
                        {
                            Source = i,
                            Destination = j
                        }));
                    }
                }
            }
            sortedEdges = sortedEdges.OrderBy(item => item.Key).ToList();
            return sortedEdges;
        }

        private void BuildSpanningTree()
        {
            foreach (var keyValuePair in _sortedEdges)
            {
                var sourceVertex = keyValuePair.Value.Source;
                var destiantionVertex = keyValuePair.Value.Destination;
                var sourceSet = FindUnionSet(sourceVertex);
                var destinationSet = FindUnionSet(destiantionVertex);
                if (sourceSet != destinationSet)
                {
                    SpanningTree.Add(keyValuePair.Value);
                    BuildUnionSet(sourceSet, destinationSet);
                }
            }
        }

        private void BuildUnionSet(int sourceSet, int destinationSet)
        {
            _vertices[sourceSet] = destinationSet;
        }

        private int FindUnionSet(int vertex)
        {
            return _vertices[vertex] == -1 ? vertex : FindUnionSet(_vertices[vertex]);
        }

        public void PrintSortedEdges()
        {
            Console.WriteLine("Weight \tSource \tDestination");
            foreach (var keyValuePair in _sortedEdges)
            {
                Console.WriteLine(string.Format("{0} \t{1} \t{2}", keyValuePair.Key, keyValuePair.Value.Source, keyValuePair.Value.Destination));
            }
        }
    }
}
