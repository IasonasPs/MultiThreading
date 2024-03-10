using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.PassDataSafely
{
    internal class PassData_Unsafe_
    {

        public static void PassDataUnsafely()
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Write);

            Thread thread = new Thread(parameterizedThreadStart);
            thread.Name = "Testing Abort";

            thread.Start(12);
            thread.Join();

            //thread.Start("123");// Unable to cast object of type 'System.String' to type 'System.Int32'

        }

        public static void Write(object num)
        {
            var result = (int)num; 
            Console.WriteLine(result + 10);
        }
    }
}
