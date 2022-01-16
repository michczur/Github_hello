using System;

namespace Github_hello
{
    class Program
    {
        static void Price_list(double price, int lines)
        {
            for (int i = 1; i <= lines; i++)
            {
                Console.WriteLine("Liczba sztuk:" + i + " łaczna cena: " + price * i + " zł");
            }

        }
        static void Main(string[] args)
            {
                Console.WriteLine("podaj cene");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("podaj ilosc produktow");
                int lines = Convert.ToInt32(Console.ReadLine());
                Price_list(price, lines);

            }
    }
}

