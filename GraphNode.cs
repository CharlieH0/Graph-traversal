using System;
using System.Collections.Generic;
using System.Text;

namespace Graph_traversal
{
    class GraphNode
    {
        public string data;
        public GraphNode[] connections;
        public GraphNode(int cons)
        {
            connections = new GraphNode[cons];
        }
    }
}
