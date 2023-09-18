using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Crocodile:Reptile
    {
        protected bool isdodentalcare;
        public Crocodile(bool isdodentalcare, string name, int age, bool isApexPredator, int caloris, int taillength)
           : base(name, age, isApexPredator, caloris, taillength)
        {
            this.isdodentalcare = isdodentalcare;
        }
        public bool getIsdoDentalcare()
        {
            return isdodentalcare;
        }
        public void SetIsdoDentalcare(bool isdoDentalcare)
        {
            this.isdodentalcare = isdodentalcare; 
        }
        public override string ToString()
        {
            return $"isdoDentalcare:{isdodentalcare}";
        }
    }
}
