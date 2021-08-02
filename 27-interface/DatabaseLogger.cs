using System;

namespace _27_interface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database Logger...");
        }
    }
}