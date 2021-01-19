using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.AdiSoyadi + " "+ "Aramıza Hoşgeldin!!");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.AdiSoyadi + " " + "Tekrar Görüşmek Dileğiyle!");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler) 
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.TCno);
                Console.WriteLine(musteri.AdiSoyadi);
                Console.WriteLine(musteri.kayitYili);
                Console.WriteLine(musteri.tipi);
                Console.WriteLine("-----------------");

            }
            
        }
    }
}
