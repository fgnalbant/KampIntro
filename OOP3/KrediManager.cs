using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface birbirinin alternatifi olan ancak kod içerikleri farklı olan durumlar için kullanılır.
    //konutta da taşitta da hesapla var.Ancak hesaplama biçimi farklı.Bu yüzden class yerine interface olarak tanımlanır.
    //diğer tüm kredi managerlar hesapla ve biseyyap metotlarını kullanmak zorunda interface olunca (bu şablondur)
    interface IKrediManager //Okunurluğu arttırmak için interf leri I ile başlatırız
    {
        public void Hesapla();
        void BiseyYap();          
    

    }

    //loglama bir sistemde işlemi kimin yaptığını görmek için.Örneğin müşteri silinmiş kim sildi vs.
}
