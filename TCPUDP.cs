using System;

class Program
{
    static void Main()
    {
        int Z = int.Parse(Console.ReadLine());

        while (Z-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            int k = int.Parse(first[0]);
            int p = int.Parse(first[1]);

            bool[,] reach = new bool[k + 1, k + 1];

            for (int i = 1; i <= k; i++)
                reach[i, i] = true;

            for (int i = 0; i < p; i++)
            {
                string[] edge = Console.ReadLine().Split();
                int a = int.Parse(edge[0]);
                int b = int.Parse(edge[1]);

                reach[a, b] = true;
            }

            // Floyd-Warshall
            for (int mid = 1; mid <= k; mid++)
                for (int from = 1; from <= k; from++)
                    if (reach[from, mid])
                        for (int to = 1; to <= k; to++)
                            if (reach[mid, to])
                                reach[from, to] = true;

            int z = int.Parse(Console.ReadLine());

            for (int i = 0; i < z; i++)
            {
                string[] query = Console.ReadLine().Split();
                int a = int.Parse(query[0]);
                int b = int.Parse(query[1]);

                if (!reach[a, b])
                    Console.WriteLine("0");
                else if (reach[b, a])
                    Console.WriteLine("TCP");
                else
                    Console.WriteLine("UDP");
            }
        }
    }
}