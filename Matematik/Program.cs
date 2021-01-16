using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5, 6);
            dortIslem.Cikar(15, 9);
        }
    }
}
