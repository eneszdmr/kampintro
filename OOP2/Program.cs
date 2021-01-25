using System;

namespace OOP2
{
    class Program
    {

        // eğer senin BASE sınıfın varsa o senin referans tutucundur. yani burda Musteri sınıfı her iki sınıf tarafından inherit ediliyor.
        


        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.id = 1;
            musteri1.Adi = "enes";
            musteri1.Soyadi = "demir";
            musteri1.TcNo = "12345645";
            musteri1.MusteriNo = "ABC222222";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.id = 2;
            musteri2.SirketAdi = "şirketler";
            musteri2.VergiNo = "EEE12345";
            musteri2.MusteriNo = "123AB132";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri4);
            musteriManager.Add(musteri1);





        }
    }
}
