using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovarijantnost
{
    internal interface IDohvati<out T>
    {
        public T? IDohvati();
    }
    internal interface IDodaj<in T>
    {
        public void Dodaj(T novi);
    }
    internal class Grupa<T> : IDohvati<T>, IDodaj<T>
    {
        public List<T> clanovi = [];

        public void Dodaj(T novi)
            => clanovi.Add(novi);

        public T? IDohvati()
        {
            if (clanovi is null || clanovi.Count == 0)
                return default;
            T temp = clanovi[0];
            clanovi.RemoveAt(0);
            return temp;
        }
    }
    internal class Osoba
    {
        public string id = "";
        public virtual Osoba Klon()
            => new() { id = id };
    }
    internal class Zaposlenik : Osoba
    {
        public decimal placa = 0;
        public override Zaposlenik Klon()
            => new Zaposlenik() { id = id, placa = placa };
    }
    internal class Student : Osoba
    {
        public double prosjek = 0;
    }
}
