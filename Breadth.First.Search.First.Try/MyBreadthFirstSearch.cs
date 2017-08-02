using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth.First.Search.First.Try
{
    public class MyBreadthFirstSearch
    {
        private readonly int[][] _graph;

        public MyBreadthFirstSearch(int[][] graph)
        {
            _graph = graph;
        }

        public void Traverse()
        {
            bool[] visiteds = new bool[_graph.Length];
            MyQueue queue = new MyQueue(_graph.Length);

            int startVertex = 0;
            queue.Enqueue(startVertex);
            visiteds[startVertex] = true;

            while (queue.Size() > 0)
            {
                int s = (int)queue.Dequeue();
                Console.Write(s);
                visiteds[s] = true;
                var adjacencyVertexs = new List<int>();
                for (int i = 0; i < _graph.Length; i++)
                {
                    if (_graph[s][i] == 1 && !visiteds[i])
                    {
                        adjacencyVertexs.Add(i);
                    }
                }
                adjacencyVertexs.ToList().ForEach(vertex =>
                {
                    visiteds[vertex] = true;
                    queue.Enqueue(vertex);
                });
            }

        }

    }
}
