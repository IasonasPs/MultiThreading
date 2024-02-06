using System;

namespace IntroToThreads.RetrieveDataFromThreadFunction
{
    public delegate void ResultCallbackDelegate(int Results);
    public class retreiveHelper
    {
        private int _number;
        private ResultCallbackDelegate _callback;

        public retreiveHelper(int Number, ResultCallbackDelegate resultCallbackDelegate)
        {
            _number = Number;
            _callback = resultCallbackDelegate;
        }

        public void CalculateSum()
        {
            int Result = 0;
            for (int i = 0; i < _number; i++)
            {
                Result += i;
            }
            if (_callback != null)
            {
                _callback(Result);
            }
        }
    }
}
