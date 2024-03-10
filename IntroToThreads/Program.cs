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
            //ThreadClass.ThreadMain();
            PassData_Unsafe_.PassDataUnsafely();
            //PassDataWithSafety.PassDataSafely();
            //RetrieveData.RetrieveMain();
            //ThreadWithoutJoin.ThreadJoinMain();
            //ThreadJoin.ThreadJoinMain();
            //ΤhreadSyncProgram.ThreadSyncMain();
            IntroToMonitor.MonitorMain();
            #endregion
        }

        public static  void Test( [Optional, DefaultParameterValue(2)] object y)
        {
        }
    }
}

