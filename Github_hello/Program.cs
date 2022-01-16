using System;

namespace Github_hello
{
    class Program
    {
        static void Power(int number, int power)
        {
            for (int i = 1; i <= power; i++)
            {
                number = number * power;                
            }
            Console.WriteLine(number);
        }
        static void Main(string[] args)
            {
                Console.WriteLine("podaj podstawe");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj wykladnik");
                int power = Convert.ToInt32(Console.ReadLine());
                Power(number, power);

            }
    }
}

