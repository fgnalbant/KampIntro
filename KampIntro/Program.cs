using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği - yorum satırı
            //değer tutucu , alias,takma isim - kategoriEtiketi
            string kategoriEtiketi = "Kategoriler" ;
            int ogreciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Goster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu Goster");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu Goster");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
           

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
