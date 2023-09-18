using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected bool isApexPredator;
        protected int caloris;

        public Animal(string name, int age, bool isApexPredator, int caloris)
        {
            this.name = name;
            this.age = age;
            this.isApexPredator = isApexPredator;
            this.caloris = caloris;
        }
        
        public string GetName()
        {
            return name;
        }
        public int GetAge() { return age; }
        public bool GetIsApexPredator() {  return isApexPredator; }
        public int GetCaloris() { return caloris; }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age)
        {
            this.age = age; 
        }
        public void SetIsApexPredator(bool IsApexPredator)
        {
            this.isApexPredator = IsApexPredator;
        }
        public void SetCaloris(int caloris)
        {
            this.caloris = caloris;
        }
        public override string ToString()
        {
            return $"name:{name}\nage:{age}\nIsApexPredator:{isApexPredator}\ncaloris:{caloris}";
        }
        public int Eat() 
        {
            return this.caloris * 3;
        }
    }
}
