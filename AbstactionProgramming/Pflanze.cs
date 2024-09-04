using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionProgramming
{
    abstract class Pflanze
    {
        public string name;
        protected int wachtumsrate;
        protected int wasserbedarf;

        public Pflanze (string name, int wachstumsrate, int wasserbedarf)
        {
            this.name = name;
            this.wachtumsrate = wachstumsrate;
            this.wasserbedarf = wasserbedarf;
        }

        public abstract void Wachsen();

        public void Gießen(int menge)
        {
            Console.WriteLine($"{name} wurde mit {menge} Litern Honigmet gegossen. {name} geht es jetzt wesentlich besser.");
        }
        
    }
}
