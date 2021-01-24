using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
        //buraya istediğin tipi yazabilirsin. string, int, double etc.
        //T kullanımı: kullanıcı hangi tipte eleman gönderirse göndersin onu kabul et ve kullan
    {
        T[] items;

        //constructor class'ı newlediğinde otomatik çalışır
        //kısayolu ctor tab tab
        public MyList()
        {
            items = new T[0];
            //kolleksiyonlar aslında dizileri yöneten sınıflardır
            //elemanlarını dizilerde tutarak yönetirler
            //bunun için bir dizi kullanmak ve onu newlemek zorundasın
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            //bu sayede elemanlar kaybolmayacak
            items = new T[items.Length + 1];
            //dizinin eleman sayısını 1 arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                //emanet verdiğin değerleri sırasıyla geri al
            }
            items[items.Length - 1] = item;
            //eklemek istediğin yeni elemanı da şu an ekledin
        }
    }
}
