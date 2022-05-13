using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListLes
{
    
    class Program
    {
        public static int COUNT = 1000000;
        static void Main(string[] args)
        {

            Console.WriteLine(">>> Welcome <<<\n");

            Console.WriteLine("> Enter the List type you would like to create: ");

            Console.WriteLine("> S - Simple List<T>");
            Console.WriteLine("> A - ArrayList");
            Console.WriteLine("> L - LinkidList");

            string ListType = Console.ReadLine();
            IListType simpleList4 = Lists(ListType);

            Speed infoSpeed = new Speed(simpleList4);

            infoSpeed.FillinListSpeed();
            infoSpeed.SearchSpeed();
            infoSpeed.ThreeAxesSpeed();
            
            
            
          
        }

        private static IListType Lists(string ListType) =>
       ListType.ToLower() switch
       {
           "s" => new SimpleList(),
           "a" => new ArraySimpleList(),
           "l" => new LinkedSimpleList(),
           _ => null
       };

        

        

    }
}
