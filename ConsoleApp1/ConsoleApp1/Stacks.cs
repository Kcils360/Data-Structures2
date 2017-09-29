using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stacks : Node
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Stack(int Data)
        {
            Head = new Node(Data);
            return Head.Data;
        }

        public void Push(int Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
        }

        public int Pop()
        {
            if (Head == Tail)
            {
                Tail = null;
            }
            Node temp = Head.Next;
            Head.Next = null;
            int Value = Head.Data;
            Head = temp;

            return Value;
        }

    }
}
