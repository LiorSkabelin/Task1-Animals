using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class chicken:Bird
    {
        protected int weight1;
        public chicken(int weight1, string name, int age, bool isApexPredator, int caloris, int flightaltitude, int wingspanlength) :
                base(name, age, isApexPredator, caloris, flightaltitude, wingspanlength)
        {
            this.weight1 = weight1;

        }
        public int getWeight()
        {
            return weight1;
        }
        public void weight(int weight)
        {
            this.weight1 = weight;
        }
        public override string ToString()
        {
            return $"weight1:{weight1}";
        }
    }
}
