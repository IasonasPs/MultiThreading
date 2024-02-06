using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.PassDataSafely
{
    internal class PassDataWithSafety
    {
        public static void PassDataSafely()
        {
            Helper helper = new Helper(4);
            //With the use of the Helper class instance we pass the parameter in the Helper class object itself
            //thus there is no need for a ParameterizedThreadStart!

            Thread t1 = new Thread(new ThreadStart(helper.Print));

            t1.Start();   
        }
        #region Type unsafe ! (once more..)
        //Type safety : At compilation time , if we pass any data other than an integer,
        //______________then it should give a Compile-time error.

        //using object type is not type safe!!
        //as it can accept any type as parameter...
        //public static void Print(object obj)
        //{
        //    int num = Convert.ToInt32(obj);
        //    for (int i = 0; i < num; i++)
        //    {
        //        Console.WriteLine("i = {0}", i);
        //    }
        //}
        #endregion
    }
}
