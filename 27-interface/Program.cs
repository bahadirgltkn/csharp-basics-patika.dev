using System;

namespace _27_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();


            //                                  FileLogger instance 
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
