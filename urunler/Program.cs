using System;

namespace urunler
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.id = 1;
            product1.adi = "araba";
            product1.aciklama = "honda";
            product1.fiyati = 150000;

            Product product2 = new Product();
            product2.id = 1;
            product2.adi = "bisiklet";
            product2.aciklama = "bissan";
            product2.fiyati = 150000;

            Product[] productsdizi = new Product[] { product1, product2 };

            foreach (var item in productsdizi)
            {
                Console.WriteLine(item.adi+" : "+item.aciklama);

            }

        }
    }
}
