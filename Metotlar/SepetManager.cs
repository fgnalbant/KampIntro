using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun) // Ekle bir metotdur.Bu metodun yapacağı kod süslü parantezler içine yazılır.
        {
            Console.WriteLine("Tebrikler! " + urun.Adi + " Sepete Eklendi!: ");
        }

        public void Ekle2(string urunAdi,string Aciklama,double fiyat,int stokAdedi) 
        {
            Console.WriteLine("Tebrikler! " + urunAdi + " Sepete Eklendi!: ");

        }
    }
}
