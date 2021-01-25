using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager emekliKrediManager = new EmekliKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> logger = new List<ILoggerService>() { smsLoggerService,fileLoggerService,databaseLoggerService };
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(emekliKrediManager ,logger);
            

            List<IKrediManager> krediManagers = new List<IKrediManager>() { tasitKrediManager,ihtiyacKrediManager};
          

           // basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);

            Console.ReadLine();
        }
    }
}
