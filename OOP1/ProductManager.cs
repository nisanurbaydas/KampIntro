using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // sen bana Product türünde bir şey göndereceksin ben de onu product ismiyle tutup(adresini) kullanacam
        //diyor bu method
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.")
        }

    }
}
