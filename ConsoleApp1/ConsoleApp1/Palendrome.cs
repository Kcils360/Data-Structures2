using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Palendrome : LinkedLists
    {
        public bool IsPalendrome()
        {
            if (Head == null)
            {
                throw new Exception();
            }

            Node f = Head;
            Node b = Tail;
            while (f.Data == b.Data)
            {
                f = f.Next;
                b = b.Next;

                if (f.Next == b.Next)
                {
                    return true;
                }
                if (f.Next == b)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
