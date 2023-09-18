using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Snake:Reptile
    {
        protected bool poisonous;
        public Snake(bool poisonous, string name, int age, bool isApexPredator, int caloris, int taillength)
           : base(name, age, isApexPredator, caloris, taillength)
        {
            this.poisonous = poisonous;
        }
        public bool getPoisonous()
        {
            return poisonous;
        }
        public void SetPoisonous(bool poisonous)
        {
            this.poisonous = poisonous;
        }
        public override string ToString()
        {
            return $"poisonous:{poisonous}";
        }
        public string Dance()
        {
            return "every badey dance now to tooo to to🤞✌️🤞✌️🤞";
        }
    }
}
