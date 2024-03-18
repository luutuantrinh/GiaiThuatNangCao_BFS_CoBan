using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Số đỉnh
    private List<int>[] adj; // Danh sách kề

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w); // Thêm w vào danh sách kề của v
    }

    public void BFS(int s)
    {
        bool[] visited = new bool[V]; // Mảng đánh dấu đã thăm
        Queue<int> queue = new Queue<int>(); // Hàng đợi

        visited[s] = true; // Đánh dấu đỉnh xuất phát đã thăm
        queue.Enqueue(s); // Thêm đỉnh xuất phát vào hàng đợi

        while (queue.Count != 0)
        {
            // Lấy đỉnh từ đầu hàng đợi
            s = queue.Dequeue();
            Console.Write(s + " "); // Thăm đỉnh

            // Duyệt qua tất cả các đỉnh kề của đỉnh hiện tại
            foreach (int next in adj[s])
            {
                if (!visited[next]) // Nếu đỉnh chưa thăm
                {
                    visited[next] = true; // Đánh dấu đã thăm
                    queue.Enqueue(next); // Thêm vào hàng đợi để duyệt sau
                }
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        Graph g = new Graph(8);
        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 3);
        g.AddEdge(2, 4);
        g.AddEdge(3, 5);
        g.AddEdge(4, 6);
        g.AddEdge(7, 8);

        Console.WriteLine("BFS tu dinh 1:");
        g.BFS(1);

    }
}
