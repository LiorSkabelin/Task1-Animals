using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Park
    {
        private Animal[] animalsArr;
        private int animalNum;

        public Park(int animalNum)
        {
           this.animalNum = animalNum;
           this.animalsArr = new Animal[1000];
        }
        public void AddAnimal(Animal animal) 
        {
            if(this.animalNum< this.animalsArr.Length) 
            {
                for(int i = 0; i < this.animalsArr.Length; i++) 
                {
                    if (this.animalsArr[i] == null)
                    {
                        this.animalsArr[i] = animal;
                    }
                }
            }
        }
        public List<Animal> Ander10(Animal[] arrAnimal)
        {
            List<Animal> lisanimal = new List<Animal>();
            foreach (Animal animal in arrAnimal)
            {
                if (animal.GetAge() > 10 && animal.GetIsApexPredator())
                {
                    lisanimal.Add(animal);
                }
            }
            return lisanimal;
        }
        public int Howzoxlanaf(Animal[] arrAnimal)
        {
            int sun = 0;
            foreach (Animal animal in arrAnimal)
            {
                if (animal is Bird)
                {
                    if (animal.GetIsApexPredator() == true)
                    {
                        sun++;
                    }
                }
                else if(animal is Reptile)
                {
                    if(animal.GetIsApexPredator() == true)
                    {
                        sun++;
                    }
                }
            }
            return sun;
        }
    }
}
