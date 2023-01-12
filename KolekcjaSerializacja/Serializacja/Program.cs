using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Zajecia2;

namespace Serializacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serializacja();
            Deserializacja();
        }

        static void Serializacja()
        {
            MojaKolekcja<int> kolekcja1 = new MojaKolekcja<int>(new int[] { 1, 2, 3 });
            MojaKolekcja<int> kolekcja2 = new MojaKolekcja<int>(new int[] { 4, 5, 6 });

            FileStream fs = new FileStream("dane.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, kolekcja1);
            bf.Serialize(fs, kolekcja2);
            fs.Close();
        }

        static void Deserializacja()
        {
            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            MojaKolekcja<int> kolekcja1 = (MojaKolekcja<int>)bf.Deserialize(fs);
            MojaKolekcja<int> kolekcja2 = (MojaKolekcja<int>)bf.Deserialize(fs);
            fs.Close();

            Console.WriteLine(string.Join(", ", kolekcja1));
            Console.WriteLine(string.Join(", ", kolekcja2));
            Console.WriteLine();
        }
    }
}
