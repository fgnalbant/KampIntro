using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "eklendi");
        }

        //void metodu işlem sonucu ile ilgili ektra bir bilgiye ihtiyacın olmadığında kullanırsın
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "güncellendi");
        }

        public int Topla(int sayi1, int sayi2)
        {
         return sayi1 + sayi2;// bu metot kullanılırsa sonrasında bu değeri kullanabiliriz.Veri tutar
          
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); // topla2 işlemi yapıyor ve ekrana yazdırıyor.İşlemi bitiyor.
        }

    }
}
