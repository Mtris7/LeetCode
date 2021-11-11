using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _841
    {
        //841. Keys and Rooms
        //Create DFSVisitRoom to
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool[] visited = new bool[rooms.Count];
            DFSVisitRoom(0, rooms, visited);
            return visited.Where(x => x == true).ToList().Count == rooms.Count;
        }
        private void DFSVisitRoom(int startNode, IList<IList<int>> rooms, bool[] visited)
        {
            visited[startNode] = true;
            for (int i = 0; i <= rooms[startNode].Count - 1; i++)
            {
                if (!visited[rooms[startNode][i]])
                    DFSVisitRoom(rooms[startNode][i], rooms, visited);
            }
        }
    }
}
