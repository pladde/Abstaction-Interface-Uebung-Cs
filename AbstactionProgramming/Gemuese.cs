using System;

namespace AbstactionProgramming
{
    class Gemuese : Pflanze, IEssbar
    {
        private readonly int erntemonat = 10;
        private readonly float ertrag = 4;

        public Gemuese(string name, int wachtumsrate, int wasserbedarf) : base(name, wachtumsrate, wasserbedarf)
        {
        }

        public int Erntemonat { get { return erntemonat; } }

        public float Ertrag { get { return ertrag; } }

        public override void Wachsen()
        {
            Console.WriteLine($"{base.name} wächst mit einer Wachstumsrate von {this.wachtumsrate} Punkten pro Tag.");
        }

        bool IEssbar.IstReif()
        {
            return true;
        }

        void IEssbar.Verzehren() { }

        void Ernten()
        {
            Console.WriteLine("Wird geernetet.");
        }
    }
}
