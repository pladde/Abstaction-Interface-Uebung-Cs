using System;

namespace AbstactionProgramming
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Gemuese gem = new Gemuese("Karotte", 1, 1);
            Console.WriteLine($"{gem.name} hat einen Ertrag von {gem.Ertrag}");
            Console.WriteLine($"{gem.name} ist im {gem.Erntemonat} Monat des Jahres erntbar.");
            gem.Wachsen();
            gem = null;

            Blume bloom = new Blume("Tulpe", 1, 1);

            Console.WriteLine($"\n{bloom.name} hat eine Blütenanzahl von {bloom.BluetenAnzahl}");

            bloom.Wachsen();
            bloom.Bluehen();
            bloom = null;

            Console.WriteLine("\nBitte 'ENTER' drücken um fortzufahren");
            Console.ReadLine();

            Console.WriteLine("\nProgramm wird beendet.");
        }
    }
}
