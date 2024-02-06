using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using IntroToThreads.PassDataSafely;
using IntroToThreads.RetrieveDataFromThreadFunction;
using HWND = System.IntPtr;


namespace IntroToThreads
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //ThreadClass.ThreadMain();
            //PassDataWithSafety.PassDataSafely();

            RetrieveData.RetrieveMain();
        }

        
    }
}

