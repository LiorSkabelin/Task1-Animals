using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Anaconda:Snake
    {
        protected int maximumlength;

        public Anaconda(int maximumlength, bool poisonous, string name, int age, bool isApexPredator, int caloris, int taillength)
           : base(poisonous, name, age, isApexPredator, caloris, taillength )
        {
            this.maximumlength = maximumlength;
        }
        public int getMaximumlength()
        {
            return maximumlength;
        }
        public void SetMaximumlength(int maximumlength)
        {
            this.maximumlength = maximumlength;
        }
        public override string ToString()
        {
            return $"maximumlength:{maximumlength}";
        }
    }
}
