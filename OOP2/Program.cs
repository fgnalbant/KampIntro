using System;

namespace OOP2
{
    class Program
    {
        //Gercek müsteri ve tüzel müşteri ( yani gerçek kişiler ve şirketler)
        //SOLID prensibi
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io tüzel müşteri girişi

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Musteri ana grubu hem gerçek hem tüzel müşteriyi tutabiliyor.Çünkü onlar Musteri class ından miras alıyorlar.
            //Musteri hem gerçek hem de tüzel müşterinin referansını tutabilir.O yüzden aşağıdaki gibi kaydettik.
            Musteri musteri3 = new GercekMusteri(); //new gördüğümüz zaman bellekteki ref no olduğu anlamına gelir.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }

    }
}
