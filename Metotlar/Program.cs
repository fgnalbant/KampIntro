using System;

namespace Metotlar // tekrar tekrar kullanılmayı sağlayan kod bloklarıdır.
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 3000;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdedi = 5000;


            Urun[] urunler = new Urun[] {urun1,urun2};

            // c# veri güvenli(type-safe) olduğu için forech in ilk elemanına Urun yazarız ki dizinin içeride Urun değişkenini döndürdüğünü bilelim.
            foreach (Urun urun in urunler)  // urunler dizisi içinde her bir elemanı gez.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("-----------------");

            }

            Console.WriteLine(".........METOTLAR..........");

            //instance-örnek (class örneği oluşturma)
            // encapsulation - ayrı ayrı yazacağın ve düzensiz olacak yapıları belli bir kalıba(kapsüle) sokuyoruz gibi düşünebiliriz.

            SepetManager sepetManager = new SepetManager();            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut",12,3000);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 13,5000);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 15,5);
            
        }
    }
}
