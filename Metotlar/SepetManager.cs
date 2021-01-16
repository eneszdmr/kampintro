using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler sepete eklendi! "+urun.Adi+" "+urun.Aciklama);
        }

        public void Ekle2(string adi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("eklendi sisteme! "+adi+ " "+stokadedi);
        }
    }
}
