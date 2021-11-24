using System;

namespace lesson13_Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            //[[1,2,1],[2,3,2],[1,3,4]]
            //_743.NetworkDelayTime(new int[3][] { new int[] { 1, 2, 1 }, new int[] { 2, 3, 2 }, new int[] { 1, 3, 4 } }, 3, 1);

            //n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.2], start = 0, end = 2

            //            5
            //[[1, 4],[2,4],[0,4],[0,3],[0,2],[2,3]]
            //[0.37,0.17,0.93,0.23,0.39,0.04]
            //3
            //4
            //_1514.MaxProbability(5, new int[6][] { new int[] { 1, 4 }, new int[] { 2, 4 }, new int[] { 0, 4 }, new int[] { 0, 3 }, new int[] { 0, 2 }
            //                    , new int[] { 2,3}} , new double[] { 0.37, 0.17, 0.93, 0.23, 0.39, 0.04 }, 3, 4);


            //            3
            //[[0, 1, 100],[1,2,100],[0,2,500]]
            //0
            //2
            //1

            //5
            //[[0, 1, 5],[1,2,5],[0,3,2],[3,1,2],[1,4,1],[4,2,1]]
            //0
            //2
            //2
            //_787.FindCheapestPrice(5, new int[6][] { new int[] { 0, 1, 5 }, new int[] { 1, 2, 5 }, new int[] { 0, 3, 2 } ,
            //                            new int[] { 3,1,2 }, new int[] { 1,4,1 }, new int[] { 4, 2, 1 } }, 0, 2, 2);
            //_990.EquationsPossible(new string[] { "a==b", "b==c", "c==d", "x!=c", "x==a" });
            Console.WriteLine("Hello World!");
        }
    }
}
