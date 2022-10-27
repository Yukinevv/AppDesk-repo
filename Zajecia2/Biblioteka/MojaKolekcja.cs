using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Zajecia2
{
    [Serializable]
    public class MojaKolekcja<T> : IEnumerable<T>, ISerializable where T : IComparable<T>
    {
        private readonly List<T> lista = new List<T>();

        // Wlasnosci
        public int Count => lista.Count;

        public T Max => lista.Max();

        public T Min => lista.Min();

        public MojaKolekcja()
        {
        }

        // Dodatkowo do czesci pierwszej zadania
        public MojaKolekcja(T[] tab)
        {
            foreach (T item in tab)
            {
                lista.Add(item);
            }
        }

        // Do serializacji - czesc druga zadania
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            lista.Sort();
            T[] tablica = lista.ToArray();

            info.AddValue("tablica", tablica);
        }

        protected MojaKolekcja(SerializationInfo info, StreamingContext context)
        {
            T[] tablica = (T[])info.GetValue("tablica", typeof(Array));
            lista = tablica.ToList();
        }    

        // Metody
        public void Add(T arg)
        {
            lista.Add(arg);
        }

        public void Remove(T arg)
        {
            lista.Remove(arg);
        }

        public void RemoveAt(int index)
        {
            lista.RemoveAt(index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        // Iterator
        public T this[int i] => lista[i];

        // Operatory
        public static bool operator >(MojaKolekcja<T> a, MojaKolekcja<T> b)
        {
            return a.Max().CompareTo(b.Min()) >= 0;
        }

        public static bool operator <(MojaKolekcja<T> a, MojaKolekcja<T> b)
        {
            return a.Max().CompareTo(b.Min()) <= 0;
        }
    }
}
