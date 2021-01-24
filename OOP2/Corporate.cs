using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance
    //corporate is a customer
    class Corporate:Customer
        //Tüzel
    {
        public string CompanyName { get; set; }

        public string VergiNo { get; set; }
        //bir veri üzerinde matematiksel işlemler yapmıyorsan string vermek daha mantıklıdır
        //veri uyumu için de
    }
}
