using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // extend yani miras yani inheritance
    // Muşteri = ebeveyndir
    // GercekMusteri miras alır Musteriden
    class GercekMusteri:Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
