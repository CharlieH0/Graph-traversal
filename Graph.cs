using System;
using System.Collections.Generic;
using System.Text;

namespace Graph_traversal
{
    class Graph
    {
        private GraphNode[] Nodes;
        public Graph()
        {
            Nodes = new GraphNode[5];
            Nodes[0] = new GraphNode(2);
            Nodes[0].data = "A";
            Nodes[0].connections[0] = Nodes[1];
            Nodes[0].connections[1] = Nodes[2];
            Nodes[1] = new GraphNode(2);
            Nodes[1].data = "B";
            Nodes[1].connections[0] = Nodes[0];
            Nodes[1].connections[1] = Nodes[3];
            Nodes[2] = new GraphNode(3);
            Nodes[2].data = "C";
            Nodes[2].connections[0] = Nodes[0];
            Nodes[2].connections[1] = Nodes[3];
            Nodes[2].connections[2] = Nodes[4];
            Nodes[3] = new GraphNode(2);
            Nodes[3].data = "D";
            Nodes[3].connections[0] = Nodes[1];
            Nodes[3].connections[1] = Nodes[2];
            Nodes[4] = new GraphNode(1);
            Nodes[4].data = "E";
            Nodes[4].connections[0] = Nodes[2];
        }
        
    }
}
