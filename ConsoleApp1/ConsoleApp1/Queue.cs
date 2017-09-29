using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue : Stacks
    {
        Stacks one = new Stacks();
        Stacks two = new Stacks();

        public Queue()
        {
            Node Head = one;
            Node Tail = Head;
        }

        public void Enqueue()
        {
            Tail.Next = two;
            Tail = Tail.Next;
        }
    }
}
