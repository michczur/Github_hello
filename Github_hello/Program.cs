using System;

namespace Github_hello
{
    class Program
    {
        static void Arythmetics_progression(int start, int diff, int end)
        {
            int resoult = 0;
            for (int i = start; i <= start+end; i++)
            {
                resoult= diff*end;
            }
            Console.WriteLine(resoult);
        }
        static void Main(string[] args)
            {
                Console.WriteLine("podaj początek");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj róznice miedzy kolejnymi elementami ciagu");
                int diff = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj ilosc elementow ciagu");
                int end = Convert.ToInt32(Console.ReadLine());
                Arythmetics_progression(start, diff, end);

            }
    }
}

