using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICrediManager tasitKrediManager = new TasitKrediManager();
            ICrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<ICrediManager> krediler = new List<ICrediManager> {ihtiyacKrediManager,konutKrediManager,tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            



        }
    }
}
