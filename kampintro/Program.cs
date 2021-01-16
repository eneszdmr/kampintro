using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba dünya!");

            int sayi = 1500;
            bool sistemeGirisYapilmismi = true;

            if (sistemeGirisYapilmismi ==true)
            {
                Console.WriteLine("giriş doğru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }
        }
    }
}
