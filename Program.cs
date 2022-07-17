using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();
            ILoggerService smslogger = new SmsLoggerService();



            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,smslogger);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
