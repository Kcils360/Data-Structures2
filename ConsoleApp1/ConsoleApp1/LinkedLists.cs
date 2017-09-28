using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class LinkedLists
    {
        public Node Head;
        public Node Tail;
        public Node Current;
        public int Count;

        public void LinkedList()
        {
            Head = new Node();
            object head = null;
            Current = Head;
            
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            Current.Next = newNode;
            Current = newNode;
            Count++;
        }
    }
}
