using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToThreads.PassDataSafely
{
    internal class Helper
    {
        int _num;
        public Helper(int num)
        { 
            _num = num; 
        }

        public void Print()
        {
            for (int i = 0; i < _num; i++)
            {
                Console.WriteLine("i = {0}", i);
            }
        }
    }
}
