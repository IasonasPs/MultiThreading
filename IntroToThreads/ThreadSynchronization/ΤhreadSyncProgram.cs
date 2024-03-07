using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.ThreadSynchronization
{
    public class ΤhreadSyncProgram
    {

        public static void ThreadSyncMain()
        {
            BookShow bookShow = new BookShow();

            Thread t1 = new Thread(bookShow.TicketBooking)
            {
                Name = "Thread1"  // thats the t1 thread's name
            };
            Thread t2 = new Thread(bookShow.TicketBooking)
            {
                Name = "Thread2" // t2 thread's name...
            };
            Thread t3 = new Thread(bookShow.TicketBooking)
            {
                Name = "Thread3" // t3 ...
            };

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadKey();
        }
    }

    // Exclusive and Non-Exclusive Lock
    //I. Exclusive lock : An exclusive lock makes sure that only one thread
    //can gain access or enter a critical section at any given point in time
    //
    //II. Non-Exclusive lock : provide read-only access to a shared resource and limits concurrency,
    //i.e. , limits the number of concurrent accesses to a shared resource.
    // In C# non-Exclusive locks can be implemented using Semaphore, SemaphoreSlim and readerWriterLockSlim classes
}
