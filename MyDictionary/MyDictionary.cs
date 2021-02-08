using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] array;
        T[] tempArray;//geçiçi dizi

        public MyDictionary()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            tempArray = array;//diziyi geçici diziye eşitledik çünkü yeni eleman eklendiğinde eski eleman silinecek.
            array = new T[array.Length+1];
            for (int i = 0; i < tempArray.Length; i++)//geçici dizi elemanları 1 arttırılır.
            {
                array[i] = tempArray[i];//normal listedeki eski elemanlar silinmesin diye geçici diziye aktarmıştık.Burada geçici diziye aktarılan elemanları geri aldık.
                
            }
            array[array.Length - 1] = item;
        }
        public int Count
        {
            get { return array.Length; }
        }
        public void All()
        {
            foreach(T isim in array)
            {
                Console.WriteLine("İsim: " +isim);
            }
        }


    }
}
