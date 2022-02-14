using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayi gir: ");
            int a = int.Parse(Console.ReadLine());
            int sayi = 1;
            while (sayi <= a)
            {
                Console.Write(a - sayi + 1);
                sayi++;
            }
            Console.Write("...");
        }
    }
}