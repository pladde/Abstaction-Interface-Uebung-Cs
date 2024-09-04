using System;

namespace AbstactionProgramming
{
    internal class Blume : Pflanze
    {
        private readonly string farbe = "rot";
        private readonly int bluetenAnzahl = 6;

        public Blume(string name, int wachtumsrate, int wasserbedarf) : base (name, wachtumsrate, wasserbedarf)
        {
        }

        public string Farbe { get { return farbe; } }

        public int BluetenAnzahl { get { return bluetenAnzahl; } }
        

        public override void Wachsen()
        {
            Console.WriteLine($"{base.name} wächst mit einer Wachstumsrate von {wachtumsrate} Puntken pro Tag.");
        }

        public void Bluehen()
        {
        }
    }
}
