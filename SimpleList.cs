using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListLes
{

    class SimpleList : IListType
    {
        List<int> simpleList = new List<int>();

        public void Add()
        {
            for (int i = 0; i < Program.COUNT; i++)
            {
                simpleList.Add(i);
            }
            
        }

        public void SearchMethod()
        {
            simpleList.BinarySearch(496753);
        }

        public void ThreeAxes()
        {
            foreach(var item in simpleList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
