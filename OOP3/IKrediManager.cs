using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceler genellikle operasyon classlarında kullanılır
    interface IKrediManager
        //interfaceler birer şablondur
        //birclass bir interface'i kullanıyorsa 
        //o interface'teki metodu kullanmak zorundadır
    {
        //şu imza aynı(hepsinde var)
        //ama tek başına anlam ifade etmiyorsa
        //class yerine interface kullan
        void Hesapla();
        void BiseyYap();
    }
}
