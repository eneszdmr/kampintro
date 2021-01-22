using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();


            urun1.Adi = "elma";
            urun1.Fiyati = 50;
            urun1.Aciklama = "amasya elma";
            urun2.Adi = "karpuz";
            urun2.Fiyati = 49;
            urun2.Aciklama = "diyarbekir Karpuzu";
            urun3.Adi = "kiraz";
            urun3.Fiyati = 20;
            urun3.Aciklama = "güzel kiraz";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("---------------Metotlar------------------");


            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun3);


            sepetmanager.Ekle2("salata", "hiyar", 50,2);


        }
    }
}
