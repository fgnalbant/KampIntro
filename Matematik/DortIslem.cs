﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {

        public void Topla(int sayi1,int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç:" + toplam);
      
        }
        Console.WriteLine("------------------------------");
        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Sonuç:" + cikar);

        }
    }
}
