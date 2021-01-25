using System;

namespace OOP3
{
    class SmsLoggerService : ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS and sent to customer");
        }
    }
}
