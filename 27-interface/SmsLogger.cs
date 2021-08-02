using System;

namespace _27_interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sms Logger...");
        }
    }
}