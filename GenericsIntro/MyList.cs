using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Mylist'imde T ile çalışacağım demek.
    {
        T[] items; // dizi ekledik.Aşağıdaki item dan bağımsız.

        //constructor-yapıcı ( bir class newlendiğinde çalışan bloktur)
        //aşağıdaki blok T item eklediğimiz gibi 0 elemanlı bir new array oluşturur.
        //Bu da program.cs içinde her seferinde new array oluşturma ihtiyacını ortadan kaldırır.
        public MyList()
        {
            items = new T[0]; // elimde artık 0 elemanlı bir dizi var.
        }
        public void Add(T item) // T bizim verdiğimiz bir tür.String gibi
        {
            T[] tempArray = items; // alt satırda new array oluştururken mevcut items arrayı referans numarası kaybolmasın diye o referans numarasını "geçiciArray" olarak tanımladığım değişkene tutturuyorum.   
            items=new T[items.Length+1]; //Add çalışınca T dizisi eleman sayısını 1 arttırır.       
            for (int i = 0; i < tempArray.Length; i++) // 0 dan başlayıp tempArray kadar gez.
            {
                items[i] = tempArray[i]; // tempArray a verilen geçici elemanlar sırasıyla items arrayine geri alınır.
            }

            items[items.Length - 1] = item; // bir üst satırda items arrayi içinde oluşturduğumuz boş alana Add() modülü içinde yazdığımız item'ı eklemek için.        
        }

    }
}
