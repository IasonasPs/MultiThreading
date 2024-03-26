using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using IntroToThreads.PassDataSafely;
using IntroToThreads.RetrieveDataFromThreadFunction;
using HWND = System.IntPtr;
using IntroToThreads.JoinMethod;
using IntroToThreads.ThreadSynchronization;
using System.Xml.Linq;


namespace IntroToThreads
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Main methods:
            //ThreadClass.ThreadMain();              //000
            //PassData_Unsafe_.PassDataUnsafely();    //001
            //PassDataWithSafety.PassDataSafely();     //002
            //RetrieveData.RetrieveMain();              //003
            //ThreadWithoutJoin.ThreadJoinMain();        //004
            //ThreadJoin.ThreadJoinMain();                //005
            //ΤhreadSyncProgram.ThreadSyncMain();          //006
            IntroToMonitor.MonitorMain();


            #endregion
        }

        public static void Test([Optional, DefaultParameterValue(2)] object y)
        {
        }

        //public static void Print()
        //{
        //    StringBuilder odd = new StringBuilder();
        //    StringBuilder even = new StringBuilder();

        //    for (int i = 0 ; i < 500 ; i++)
        //    {
        //        if (i%2 != 0) //ODD
        //        {
        //            odd.Append(i.ToString()+",");
        //        }
        //        else //EVEN
        //        {
        //            even.Append(i.ToString()+",");
        //        }
        //        Console.Clear();
        //        Console.Write("Odd Numbers : "+odd);
        //        Console.Write("Even NUmbers : "+even);
        //        Thread.Sleep(100);   
        //    }
        //}



    }
}

