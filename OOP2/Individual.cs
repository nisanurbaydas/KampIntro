using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance 
    //customer is a customer
    class Individual:Customer
        //bireysel müşteri
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
