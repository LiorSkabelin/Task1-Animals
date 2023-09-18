using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Cow:Mammal
    {
        protected int numlitters;
        public Cow(int numlitters, int milkcaloris, int pregnancy,string name, int age, bool isApexPredator, int caloris) 
            : base(name, age, isApexPredator, caloris, milkcaloris, pregnancy)
        {
            this.numlitters = numlitters;
        }
        public int getNumlitters()
        {
            return numlitters;
        }
        public void SetNumlitters(int Numlitters)
        {
            this.numlitters = Numlitters;
        }
        public override string ToString()
        {
            return $"Numlitters:{numlitters}";
        }
        public new int Eat()
        {
            return (base.Eat()/4);
        }
    }
}
