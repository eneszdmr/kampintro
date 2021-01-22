using System;

namespace refAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("referans ve değer tipleri");
            int number1 = 25;
            int number2 = 30;

            var result = AddandSee(number1,number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
        }
        static int AddandSee(int number1, int number2)
        {
            number1 = 99; 
            return number1 + number2;
        }
    }
}
