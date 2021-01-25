using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] isimler = new string[] { "engin", "murat", "kerem", "halil" };

            Console.WriteLine(isimler[0]);

            List<String> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };

            Console.WriteLine();

            List<int> numeralar = new List<int>();
            numeralar.Add(50);

            Console.WriteLine(numeralar[0]);


        }
    }
}
