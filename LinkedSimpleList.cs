using System;
using System.Collections.Generic;
using System.Text;

namespace ListLes
{
    class LinkedSimpleList : IListType
    {
        LinkedList<int> linkSimplList = new LinkedList<int>();
        public void Add ()
        {           
            for (int i = 0; i < Program.COUNT; i++)
            {
                linkSimplList.AddLast(i);
            }
            
        }

        public void SearchMethod()
        {
            linkSimplList.Find(496753);
        }

        public void ThreeAxes()
        {
            foreach (int item in linkSimplList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
