using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace IntroToThreads.ThreadSynchronization
{
    public class IntroToMonitor
    {
        public static void MonitorMain()
        {
            #region Enter and OverLoad
            //Thread[] threads = new Thread[3];
            //for (int i = 0 ; i < 3 ; i++)
            //{
            //    threads[i] = new Thread(PrintNumbers)
            //    {
            //        Name = $"ChildThread[{i}]"
            //    };
            //}
            //foreach (var item in threads)
            //{
            //    item.Start();
            //}
            //Console.ReadLine(); 
            #endregion

            #region TryEnter
            Thread[] threads = new Thread[3];
            for (int i = 0 ; i < 3 ; i++)
            {
                threads[i] = new Thread(TryPrintNumbers)
                {
                    Name = $"ChildThread[{i}]"
                };
            }
            foreach (var item in threads)
            {
                item.Start();
            }
            Console.ReadLine();
            #endregion

        }

        private static object lockPrintNumbers = new object();
        private static void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Trying to enter into critical section");
            bool IsLockTaken = false;
            try
            {
                Monitor.Enter(lockPrintNumbers,ref IsLockTaken);
                if (IsLockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "Entered into Critical section");
                    for (int i = 0 ; i < 5 ; i++)
                    {
                        Thread.Sleep(100);
                        Console.Write(i + ",");
                    }
                    Console.WriteLine();
                }
            }
            finally
            {
                if (IsLockTaken)
                {
                    Monitor.Exit(lockPrintNumbers);
                    Console.WriteLine(Thread.CurrentThread.Name + "Exit from critical section");
                }
            }
        }

        private static void TryPrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Trying to enter into Critical section");
            var timeout = TimeSpan.FromMilliseconds(500);
            bool lockTaken = false;
            try
            {

                Monitor.TryEnter(lockPrintNumbers,timeout,ref lockTaken);
                if (lockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "Entered into Critical section");
                    for (int i = 0 ; i < 5 ; i++)
                    {
                        Thread.Sleep(50);
                        Console.Write(i + ",");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("<------ Locked NOT aqcuired BY {0}------->",Thread.CurrentThread.Name);
                    Console.WriteLine();
                }
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(lockPrintNumbers);
                    Console.WriteLine(Thread.CurrentThread.Name + "Exit from critical section");
                }
            }
        }
    }
}
