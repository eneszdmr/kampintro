using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" adlı müşteri eklenmiştir.");
        }
        public void MusteriDelete(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " adlı müşteri bilgileri silinmiştir.");
        }

    }
}
