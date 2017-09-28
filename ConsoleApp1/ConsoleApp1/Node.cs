using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {
        internal object Value;

        public char Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public Node(char data)
        {
            Data = data;
        }

        public Node()
        {
        }
    }
}
