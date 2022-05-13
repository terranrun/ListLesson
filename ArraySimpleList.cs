using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListLes
{
    class ArraySimpleList :IListType
    {
        ArrayList arraySimpleList = new ArrayList();
        public void Add()
        {
            
            for (int i = 0; i < Program.COUNT; i++)
            {
                arraySimpleList.Add(i);
            }
            
        }

        public void SearchMethod()
        {
            arraySimpleList.BinarySearch(496753);
        }

        public void ThreeAxes()
        {
            foreach (int item in arraySimpleList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
