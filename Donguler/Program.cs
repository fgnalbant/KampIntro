using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array = dizi
            // bir dizi tanımlamak için aşağıdaki ifade kullanılır.
            string[] kurslar = new string[] 
            {   
                "Yazılım Geliştirme Kursu",
                "Programlamaya Başlangıç için temel kurs",
                "Java",
                "python"
            };

            for (int i = 0; i <kurslar.Length; i++) // kurslar.Lenght ile kurslar dizisinin uzunluğu kadar demek istiyoruz.Yani eleman sayısı kadar.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-------------------");

            foreach (string kurs in kurslar) // Kursları dolaş.Kurslar dizisindeki her kurs elemanı için diziyi döndür.Dizi temelli yapıları tek tek dönmeye yarar.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("---------------------");



            for (int i = 1; i < 10; i++)  // 1 den başlayacağız, i 10 dan küçük olduğu sürece devam edecek, i yi 1 er 1 er arttır
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i+=2)  // 1 den başlayacağız, i 10 dan küçük olduğu sürece devam edecek, i yi 2 şer 2 şer arttır(i=i+2 de yazabilirdik)
            {
                Console.WriteLine(i);
            }
        }
    }
}
