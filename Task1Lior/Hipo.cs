using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Hipo:Mammal
    {
        protected int fatpercentage;
        public Hipo(int fatpercentage, int milkcaloris, int pregnancy, string name, int age, bool isApexPredator, int caloris)
            : base(name, age, isApexPredator, caloris, milkcaloris, pregnancy)
        {
            this.fatpercentage = fatpercentage;
        }
        public int GetFatpercentage()
        {
            return fatpercentage;
        }

        public void SetFatpercentage(int fatpercentage)
        {
            this.fatpercentage = fatpercentage;
        }
        public override string ToString()
        {
            return $"fatpercentage:{fatpercentage}";
        }
    }
}
