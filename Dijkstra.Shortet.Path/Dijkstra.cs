﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstra.Shortet.Path
{
    public class Dijkstra
    {
        private readonly int[,] _graph;
        private int[] _shortestPaths;
        public bool IsSingleTarget { get; set; }
        public int TargetVertex { get; set; }
        public int Size { get; }

        public Dijkstra(int[,] graph)
        {
            _graph = graph;
            Size = _graph.GetLength(0);
        }

        public int[] FindShortestPath()
        {
            var distanceVertices = Enumerable.Repeat(int.MaxValue, Size).ToArray();
            var vertices = Enumerable.Range(0, Size).ToArray();
            distanceVertices[0] = 0;
            var pickedVertices = new List<int>();
            var verticesCount = 0;

            _shortestPaths = Enumerable.Repeat(int.MinValue, Size).ToArray();

            do
            {
                var nextVertices = vertices.Where(vertext => !pickedVertices.Contains(vertext) && distanceVertices[vertext] != int.MaxValue).ToArray();
                var pickVertex =
                    nextVertices.Select(vertex => new { Vertext = vertex, Distance = distanceVertices[vertex] })
                        .OrderBy(v => v.Distance)
                        .First()
                        .Vertext;
                pickedVertices.Add(pickVertex);

                var adjacentVertices = new List<int>();
                for (var i = 0; i < Size; i++)
                {
                    if (_graph[pickVertex, i] > 0)
                    {
                        adjacentVertices.Add(i);
                    }
                }

                foreach (var adjacentVertex in adjacentVertices)
                {
                    var distanceFromSource = distanceVertices[pickVertex] + _graph[pickVertex, adjacentVertex];
                    if (distanceFromSource < distanceVertices[adjacentVertex])
                    {
                        distanceVertices[adjacentVertex] = distanceFromSource;
                        _shortestPaths[adjacentVertex] = pickVertex;
                    }
                }

                if (IsSingleTarget && pickVertex == TargetVertex)
                {
                    return new[] { distanceVertices[TargetVertex] };
                }

                verticesCount++;
            } while (verticesCount < Size);

            return distanceVertices;
        }

        public void WriteShortestPath()
        {
            var resultVerticesList = new List<int>();
            var nextVertex = TargetVertex;
            do
            {
                resultVerticesList.Add(nextVertex);
                nextVertex = _shortestPaths[nextVertex];
                if (nextVertex == int.MinValue)
                {
                    break;
                }
            } while (nextVertex != 0);
            resultVerticesList.Add(0);
            resultVerticesList.Reverse();
            Console.WriteLine(string.Join("->", resultVerticesList));
        }
    }
}
