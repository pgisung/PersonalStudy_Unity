using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleGame
{
    internal class Graph
    {
        int[,] adjacent1 = new int[6, 6]
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 },
        };

        List<int>[] adjacent2 = new List<int>[]
        {
            new List<int>() { 1, 3 },
            new List<int>() { 0, 2, 3 },
            new List<int>() { 1 },
            new List<int>() { 0, 1, 4 },
            new List<int>() { 3, 5 },
            new List<int>() { 4 },
        };

        int[,] adjacentWeight = new int[6, 6]
        {
            { -1, 15, -1, 35, -1, -1 },
            { 15, -1, 05, 10, -1, -1 },
            { -1, 05, -1, -1, -1, -1 },
            { 35, 10, -1, -1, 05, -1 },
            { -1, -1, -1, 05, -1, 05 },
            { -1, -1, -1, -1, 05, -1 },
        };

        public void Dijkstra(int start)
        {
            bool[] visited = new bool[6];
            int[] parent = new int[6];
            int[] distance = new int[6];
            Array.Fill(distance, Int32.MaxValue);

            parent[start] = start;
            distance[start] = 0;

            while (true)
            {
                int closest = Int32.MaxValue;
                int now = -1;
                for (int i = 0; i < visited.Length; i++)
                {
                    if (visited[i])
                        continue;
                    if (distance[i] == Int32.MaxValue || distance[i] >= closest)
                        continue;
                    closest = distance[i];
                    now = i;
                }

                if (now == -1)
                    break;

                visited[now] = true;

                for (int next = 0; next < distance.Length; next++)
                {
                    if (adjacentWeight[now, next] == -1)
                        continue;
                    if (visited[next])
                        continue;

                    int nextDist = distance[now] + adjacentWeight[now, next];
                    if (nextDist < distance[next])
                    {
                        parent[next] = now;
                        distance[next] = nextDist;
                    }
                }
            }
        }

        public void BFS(int start)
        {
            bool[] visited = new bool[6];
            int[] parent = new int[6];
            int[] distance = new int[6];

            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited[start] = true;
            parent[start] = start;
            distance[start] = 0;

            while (q.Count > 0)
            {
                int now = q.Dequeue();

                for (int next = 0; next < 6; next++)
                {
                    if (adjacent1[now, next] == 0)
                        continue;
                    if (visited[next])
                        continue;
                    q.Enqueue(next);
                    visited[next] = true;
                    parent[next] = now;
                    distance[next] = distance[now] + 1;
                }
            }
        }

        public void DFS(int now, bool[] visited)
        {
            visited[now] = true;

            for (int next = 0; next < 6; next++)
            {
                if (adjacent1[now, next] == 0)
                    continue;
                if (visited[next])
                    continue;
                DFS(next, visited);
            }
        }

        public void DFS2(int now, bool[] visited)
        {
            visited[now] = true;

            foreach (int next in adjacent2[now])
            {
                if (visited[next])
                    continue;
                DFS2(next, visited);
            }
        }

        public void SearchAll()
        {
            bool[] visited = new bool[6];
            for (int now = 0; now < 6; now++)
                if (visited[now] == false)
                    DFS(now, visited);//DFS2(now, visited);
        }
    }
}
