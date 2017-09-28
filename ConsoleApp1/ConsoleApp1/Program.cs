using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            public bool IsPalendrome()
            {
                if (head == null)
                {
                    throw new Exception();
                }

                Node f = Head;
                Node b = Tail;
                While(f.Data == b.Data)
                {
                    f = f.Next;
                    b = b.Next;

                    if (f.Next == b.Next || f.Next = b)
                    {
                        return true;
                    }

                }
                return false;
            }
    }
}
