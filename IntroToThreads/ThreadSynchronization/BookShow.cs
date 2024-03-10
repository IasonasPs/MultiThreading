using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.ThreadSynchronization
{
    public class BookShow
    {
        private readonly object? lockObject = new object();

        int AvailableTickets = 3;
        static int i = 1, j = 2, k = 3;
        public void BookTicket(string name, int wantedtickets)
        {
            lock (lockObject) // same could be acheived by using lock(this) but.....!
            {
                if (wantedtickets <= AvailableTickets)
                {
                    Console.WriteLine(wantedtickets + "booked to" + name);
                    AvailableTickets -= wantedtickets;
                }
                else
                {
                    Console.WriteLine("No tickets available");
                }
            }
        }
        //thread1 tries to book 1 ticket
        //thread2 tries to book 2 tickets
        //thread3 tries to book 3 tickets
        public void TicketBooking()
        {
            string? name = Thread.CurrentThread.Name ?? "noName";
            if (name.Equals("Thread1"))
            {
                BookTicket(name, i);  // i = 1
            }
            else if (name.Equals("Thread2"))
            {
                BookTicket(name, j); // j = 2
            }
            else
            {
                BookTicket(name, k); //k = 3
            }
        }
    }

    //why not using "lock(this)..."  instead of "lock(lockObject)" ??  :
    //---->lockObject is a private object that serves as the mutual-exclusion
    //     lock for accessing the shared resource or region of code...
    //---->'this' is the current instance used as the mutual-exclusion lock.

    //While both can be used to ensure thread safety, it is recommended to avoid
    //using the current instance('this') and the reason is that lock(this) exposes the lock
    //to the outside world,making it accessible and potentially leading to deadlocks..
    //In conclusion lockObject is private and "this" is not!  ?
}
