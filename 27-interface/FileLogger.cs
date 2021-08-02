using System;

namespace _27_interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("File Logger...");
        }
    }
}