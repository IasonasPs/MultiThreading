using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.JoinMethod
{
    internal class ThreadJoin
    {

        #region Join Method (overloaded) versions
        //public void Join();
        //public void Join(int millisecondsTimeout);
        //public void Join(TimeSpan timeout);
        #endregion

        public static void ThreadJoinMain()
        {
            int time = 30;

            Thread t1 = new Thread(() =>
            {
                int i = 0;
                while (true)
                {
                    Console.WriteLine(i);
                    i++;
                    if (i > 80)
                    {
                        break;
                    }
                    Thread.Sleep(time);
                }
                Console.WriteLine("t1 end");
            });

            Thread t2 = new Thread(() =>
            {
                int j = 100000000;
                while (true)
                {
                    Console.WriteLine("--------> {0}", j);
                    j++;
                    if (j > 100000100)
                    {
                        break;
                    }
                    Thread.Sleep(time);
                }
                Console.WriteLine("t2 end");
            });

            t1.Start();
            t2.Start();
            
            t1.Join();    // the calling(or lets say the parent thread?) thread is the MainThread!
            //t2.Join();
            
            Console.WriteLine("Main Thread End");
        }
    }
}
