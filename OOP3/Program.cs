using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
        //Interfaceler de miras olduğu class ın referansını tutabilir.(bkz: IKrediManager -> IhtiyacKrediManager)
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();            
            IKrediManager tasitKrediManager = new TasitKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();

            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),(new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService() })); // yukarıda seçilen kredi türüne göre hesaplama ile başvuru yap çalışır.
            //yukarıdaki parantes içi gibi de newlenebilir.


            Console.WriteLine(".............");
            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager , ihtiyacKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
