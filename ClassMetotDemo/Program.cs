using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10001;
            musteri1.TCno = "500000000";
            musteri1.AdiSoyadi = "Gizem Nalbant Arslan";
            musteri1.kayitYili = "13.10.1993";
            musteri1.tipi = "Bireysel";

            Musteri musteri2= new Musteri();
            musteri2.Id = 10002;
            musteri2.TCno = "16000000";
            musteri2.AdiSoyadi = "Emir Arslan";
            musteri2.kayitYili = "30.06.1991";
            musteri2.tipi = "Kurumsal";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);

        }
    }
}
