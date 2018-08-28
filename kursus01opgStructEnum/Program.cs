using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus01opgStructEnum
{
    enum Filtyper
    {
        csv = 1,
        pdf = 2,
        txt = 3
    }

    class Person // Omskriv til klasse for at se difference imellem struct og class. struct = Kopi && class = reference.
    {
        public int Id;
        public string Navn;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ft = Filtyper.csv;
            int kode = (int)ft;

            Console.WriteLine($"filtype = {ft}");

            Console.WriteLine($"kode af filtype = {kode}");

            Person p1 = new Person(); // Ny instans af Person p1;

            p1.Id = 1;
            p1.Navn = "Mikkel";

            Person p2 = new Person(); // Ny instans af Person p2;

            p2.Id = 2;
            p2.Navn = "Henrik";

            Person p3 = p2; // p3 er kopi af p2;

            p3.Id = 3;
            p3.Navn = "Gitte";

            p2.Navn = "Nicki";

            Console.WriteLine($"Person 01:\nId: {p1.Id}\nNavn: {p1.Navn}");
            Console.WriteLine($"Person 02:\nId: {p2.Id}\nNavn: {p2.Navn}");
            Console.WriteLine($"Person 03:\nId: {p3.Id}\nNavn: {p3.Navn}");

            Console.ReadLine();
        }
    }
}
