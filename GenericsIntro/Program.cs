using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Mylist<string> yeniListem = new Mylist<string>();
            yeniListem.Add("ankara");
            yeniListem.Add("istanbul");
            yeniListem.Add("izmir");
            yeniListem.Add("ankara");
            yeniListem.Add("ankara");
            yeniListem.Add("ilk isim");
            Console.WriteLine(yeniListem.Count);

        }
    }
}
