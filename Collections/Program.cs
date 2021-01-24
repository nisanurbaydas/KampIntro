using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Ya da daha esnek bir yapı olan list sınıfını kullanırsın
            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("İlker"); 
            //bunu yaptığın zaman var olan adreste bir eleman daha eklemiş olursun
            //diğer değerleri kaybetmeden
            Console.WriteLine(names2  [4]);
            Console.WriteLine(names2[0]);
        }
    }
}
