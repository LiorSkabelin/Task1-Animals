using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Reptile:Animal, IReptile
    {
        protected int taillength;
        public Reptile(string name, int age, bool isApexPredator, int caloris,int taillength)
            : base(name, age, isApexPredator, caloris)
        {
            this.taillength = taillength;
        }

        public void Chekhom(int hom)
        {
            Console.WriteLine(hom);
        }

        public int getTaillength()
        {
            return taillength;
        }

        public void Itgonenut()
        {
            Console.WriteLine("Mitgonen");
        }

        public void SetTaillength(int taillength)
        {
            this.taillength = taillength;
        }
        public override string ToString()
        {
            return $"taillength:{taillength}";
        }

        public void zxila()
        {
            Console.WriteLine("Zxoxel");
        }
    }
}
