using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //bir alt satırda metod injection yapılıyor.Enjekte ediliyor yani.        
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) // hangi kredi için başvuru yapıldığı bilgisi alınır ki hesaplamalar ona göre yapılsın.IKrediHepsapla herkesin ref tutabildiği için parametre olarak o verilmiştir.
        {
            //Basvuran bilgileri alınır ve değerlendirilir.
            //Çeşitli hesaplar yapılır.

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //üsteki gibi yaparsak tüm başvurular konut kredisi gibi değerlendirilir.

            krediManager.Hesapla(); // kredi hesaplamasını kredi türünden bağımsız hale getirdik.   
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Birden fazla kredi hesabı yapmak istiyoruz.List çağırıyoruz çünkü gişedeki kişinin ekrandan kaç kredi seçeceği belli değil.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();                
            }
        }

    }
}
