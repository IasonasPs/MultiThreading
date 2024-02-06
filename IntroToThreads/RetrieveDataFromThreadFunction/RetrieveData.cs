using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.RetrieveDataFromThreadFunction
{
    internal class RetrieveData
    {
        #region Declaration of ThreadStart delegates
        //public delegate void ThreadStart();
        //public delegate void ParameterizedThreadStop(object obj);

        //as the return type of these 2 delegates is void 
        //the only way to retrieve data from a thread function,
        //is by using a callback method :
        #endregion

        // We will once more need a helper class to encapsulate both the function and the data it requires

        public static void RetrieveMain()
        {
            ResultCallbackDelegate callback = new ResultCallbackDelegate(ResultCallbackMethod);
            int number = 5;

            retreiveHelper helper = new retreiveHelper(5,callback);

            Thread thread01 = new Thread(new ThreadStart(helper.CalculateSum));
            thread01.Start();
            Console.ReadKey();
        }



        //Callback Method
        public static void ResultCallbackMethod(int Result)
        {
            Console.WriteLine("is {0}", Result);
        }








    }
}

