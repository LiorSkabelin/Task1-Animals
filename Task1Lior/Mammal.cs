using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Mammal:Animal
    {
        protected int milkcaloris;
        protected int pregnancy;
          
        public Mammal(string name, int age, bool isApexPredator, int caloris, int milkcaloris, int pregnancy):
            base(name,age,isApexPredator,caloris)
        {
            this.caloris = caloris;
            this.pregnancy = pregnancy;
        }
        public int getCaloris()
        {
            return this.caloris;
        }
        public int getpregnancy()
        {
            return this.pregnancy;
        }
        public void SetMilkcaloris(int milkcaloris)
        {
            this.milkcaloris = milkcaloris;
        }
        public void Setpregnancy(int pregnancy)
        {
            this.pregnancy = pregnancy;
        }
        public override string ToString()
        {
            return $"caloris:{caloris}\npregnancy{pregnancy}";
        }
        public new int Eat()
        {
            return (base.Eat() + this.milkcaloris);
        }
    }
}
