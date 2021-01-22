using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Adi = "Mustafa";
            musteri.Soyadi = "Taş";
            musteri.Tckno = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Kaya";
            musteri2.Tckno = 0123456789;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri);

            musteriManager.MusteriDelete(musteri2);


        }
    }
}
