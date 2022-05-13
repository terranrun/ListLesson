using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ListLes
{
    class Speed
    {
        Stopwatch stopWatch = new Stopwatch();
        IListType infoSpeedList;
        public Speed(IListType list)
        {
            infoSpeedList = list;
        }

        public void FillinListSpeed()
        {
            stopWatch.Start();

            infoSpeedList.Add();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

       public  void SearchSpeed()
        {
            stopWatch.Start();

            infoSpeedList.SearchMethod();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

       public void ThreeAxesSpeed()
        {
            stopWatch.Start();

            infoSpeedList.ThreeAxes();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

    }
}
