using System;

namespace arayuzler
{
    class Program
    {
       static void Main(string[] args)
       {
         FileLogger filelogger = new();
         filelogger.WriteLog();

         DatabaseLogger databaselogger = new();
         databaselogger.WriteLog();

         SmsLogger smslogger = new();
         smslogger.WriteLog();

         LogManager logManager = new LogManager(new FileLogger());
         logManager.WriteLog();
       }
    }
}