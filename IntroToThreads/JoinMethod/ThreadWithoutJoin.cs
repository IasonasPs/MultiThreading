using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.JoinMethod
{
    internal class ThreadWithoutJoin
    {
        public static void ThreadJoinMain()
        {
            Console.WriteLine("Main Started");
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main Ended");
            Console.ReadLine();
        }

        // The Main Thread's default/anticipated behaviour,
        // is Not waiting for its child threads to complete their execution or task!!
        
        #region Methods
        static void Method1()
        {
            Console.WriteLine("Method1-Thread1 Started");
            Thread.Sleep(6000);
            Console.WriteLine("Method1-Thread1 Ended");
        }
        static void Method2()
        {
            Console.WriteLine("Method2-Thread2 Started");
            Thread.Sleep(3000);
            Console.WriteLine("Method2-Thread2 Ended");
        }
        static void Method3()
        {
            Console.WriteLine("Method3-Thread3 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method3-Thread3 Ended");
        } 
        #endregion
    }
}
