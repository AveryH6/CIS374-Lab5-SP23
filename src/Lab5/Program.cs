using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            UndirectedGraph undirectedGraph = new UndirectedGraph("../../../graphs/Savannah.txt");

            Console.WriteLine(undirectedGraph);

            var startingNode = undirectedGraph.GetNodeByName("i");

            undirectedGraph.DFS(startingNode);
=======
            UndirectedGraph undirectedGraph = new UndirectedGraph("../../../graphs/BeReal.txt");

            Console.WriteLine(undirectedGraph);

            //var startingNode = undirectedGraph.GetNodeByName("i");
            //undirectedGraph.DFS(startingNode);

            Console.WriteLine(undirectedGraph.IsReachable("gb", "mw"));

>>>>>>> 9fb8601755d8e53f385c9858ccd629cf810e4d66
        }
    }
}
