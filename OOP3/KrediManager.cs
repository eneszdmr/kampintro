using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    //****************************************
    //interfaceleri birbirinin alternatifi olan ama 
    //kod içerikleri farklı olan durumlar için  kullanırız




    interface IKrediManager
    {
        // interface içinde sadece imza metotları olur içi dolu olamaz !!!!!!
        void Hesapla();
        void BiseyYap();
    }
}
