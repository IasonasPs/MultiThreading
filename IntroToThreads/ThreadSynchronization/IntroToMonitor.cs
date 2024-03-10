using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IntroToThreads.ThreadSynchronization
{
    public class IntroToMonitor
    {
        private static readonly object lockPrintNumbers = new object();
        public static void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Trying to enter into critical section");
            try
            {
                Monitor.Enter(lockPrintNumbers);
                Console.WriteLine(Thread.CurrentThread.Name + "Entered into Critical section");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i + ",");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(lockPrintNumbers);
                Console.WriteLine(Thread.CurrentThread.Name + "Exit from critical section" );
            }
        }

        public static void MonitorMain()
        {
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(PrintNumbers)
                {
                    Name = $"ChildThread[{i}]"
                };
            }
            foreach (var item in threads)
            {
                item.Start();
            }
            Console.ReadLine();
        }
    }
}
