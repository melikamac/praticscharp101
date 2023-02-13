using System;

namespace interfaces
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sms olarak log yazar.");
        }
    }
}