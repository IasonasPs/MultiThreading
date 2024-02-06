using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads
{
    internal class ThreadClass
    {
        public static void ThreadMain()
        {
            #region public Thread(ThreadStart start);
            //ThreadStart delegate definition: public delegate void ThreadStart();   (I)

            //the ThreadStart parameter of the Thread class constructor should be
            //a method which returns void, to match the ThreadStart delegate signature

            //Thread thread = new Thread(ThreadStartBool);  //<---- this throws a compiler error CS0103
            //Thread thread0 = new Thread(new ThreadStart(ThreadStartVoid)); //}  These 2 approaches
            //Thread thread1 = new Thread(ThreadStartVoid);                  //}  are equal...
            //Thread thread2 = new Thread(delegate ()
            //{
            //    Console.WriteLine("Anonynous Method");
            //});
            //Thread thread3 = new Thread(() =>
            //{
            //    Console.WriteLine("Lamda");
            //});
            //thread0.Start();
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            //!!!The outputs of the methods of the threads are printed in a different order each time 
            //we run the app!!!Why is this happening?
            #endregion

            #region Input parameters | Pass data to thread function
            //Thread thread4 = new Thread(PrintString);
            //thread4.Start("45");
            ////-----------------> These 2 approaches are equal
            //ParameterizedThreadStart pthreadStart = new ParameterizedThreadStart(PrintString);
            //Thread thread5 = new Thread(pthreadStart);
            //thread5.Start(45);

            //Thread thread6 = new Thread(PrintInt);
            //thread6.Start("45");
            ////ParameterizedThreadStart operating on object data type makes it "type unsafe",
            ////as it will accept any type of value we pass.
            ////Besides that, Boxing and UnBoxing degrades our application performance.(WHY???)
            #endregion
        }

        #region
        public static void PrintString(object obj)
        {
            var text = Convert.ToString(obj);
            Console.WriteLine(text);
        }
        public static void PrintInt(object obj)
        {
            try
            {
                int num = Convert.ToInt32(obj);
                Console.WriteLine(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static bool ThreadStartBool()
        { return true; }
        public static void ThreadStartVoid()
        {
            Console.WriteLine("Void");
        }
        #endregion
    }
}
