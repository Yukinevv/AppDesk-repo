using System;

namespace Zajecia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MojaKolekcja<int> kolekcja1 = new MojaKolekcja<int>(new int[] { 1, 2, 3 });
            MojaKolekcja<int> kolekcja2 = new MojaKolekcja<int>(new int[] { 4, 5, 6 });

            kolekcja1.Add(1);
            kolekcja1.Remove(2);
            kolekcja1.RemoveAt(0);

            Console.WriteLine("Ilosc elementow: " + kolekcja1.Count);
            Console.WriteLine("Max = " + kolekcja1.Max);
            Console.WriteLine("Min = " + kolekcja1.Min);

            Console.WriteLine(kolekcja1 < kolekcja2);
            Console.WriteLine(kolekcja1 > kolekcja2);
        }
    }
}
