using System;
using System.Reflection;
using System.Security;
using Task1Lior;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] arrMammal =
            {
                new Mammal(name: "m1",age: 10,pregnancy:9,caloris:1028,isApexPredator:true,milkcaloris:50),
                new Mammal(name: "m2",age: 12,pregnancy:4,caloris:1053,isApexPredator:false,milkcaloris:60),
                new Mammal(name: "m3",age: 6,pregnancy:2,caloris:1089,isApexPredator:true,milkcaloris:70),
                new Mammal(name: "m4",age: 23,pregnancy:7,caloris:1059,isApexPredator:false,milkcaloris:30),
                new Mammal(name: "m5",age: 9,pregnancy:6,caloris:1158,isApexPredator:true,milkcaloris:20),

            };
            foreach(var m in arrMammal)
            {
                Console.WriteLine(m);
            }
            Reptile[] arrReptile =
            {
                new Crocodile(name:"r1",age: 4 , isApexPredator:false, caloris:3555,taillength:66 , isdodentalcare: true),
                new Crocodile(name:"a2",age: 6 , isApexPredator:true, caloris:3455,taillength:57 , isdodentalcare: false),
                new Snake(name: "r3",age:14, isApexPredator: true,caloris:50,taillength:17,poisonous: true),
                new Snake(name: "r4",age:13, isApexPredator: true,caloris:58,taillength:87,poisonous: false),
                new Snake(name: "r5",age:14, isApexPredator: true,caloris:50,taillength:17,poisonous: false),

            };
            foreach (var m in arrReptile)
            {
                Console.WriteLine(m);
            }
            Animal[] arrAnimal =
            {
                new Hipo(name:"a1",age: 20 , isApexPredator:false, caloris:2306, milkcaloris: 65,fatpercentage: 45,pregnancy:62),
                new Cow(name:"a2",age: 16 , isApexPredator:true, caloris:2355, numlitters:69, milkcaloris:55,pregnancy:36),
                new Hipo(name:"a3",age: 30 , isApexPredator:true, caloris:2546, milkcaloris: 35,fatpercentage: 25,pregnancy:12),
                new Crocodile(name:"a4",age: 9 , isApexPredator:false, caloris:3605,taillength:56 , isdodentalcare: true),
                new Cow(name:"a5",age: 15 , isApexPredator:false, caloris:2305, numlitters:52, milkcaloris:65,pregnancy:56),
                new Hipo(name:"a6",age: 25 , isApexPredator:true, caloris:2306, milkcaloris: 65,fatpercentage: 45,pregnancy:62),
                new Crocodile(name:"a7",age: 9 , isApexPredator:true, caloris:3605,taillength:56 , isdodentalcare: true),
                new Hipo(name:"a8",age: 20 , isApexPredator:false, caloris:2566, milkcaloris: 35,fatpercentage: 54,pregnancy:72),
            };
            foreach (var m in arrAnimal)
            {
                Console.WriteLine(m);
            }
        }
        public static int Calorisforalll(Animal[] arrAnimal)
        {
            int sum = 0;
            foreach (Animal animal in arrAnimal)
            {
                sum = sum+ animal.Eat();
            }
            return sum; 
        }
        public static int SumPredators(Animal[] arrAnimal)
        {
            int sum=0;
            foreach (Animal animal in arrAnimal)
            {
                if(animal.GetIsApexPredator()== true)
                {
                    sum = sum + 1;
                }
            }
            return sum;
        }
        public static void Mydance(Animal[] arrAnimal)
        {
            foreach (Animal animal in arrAnimal)
            {
                if(animal is Bird)
                {
                    (animal as Bird).Dance();
                }
                else if(animal is Snake)
                {
                    (animal as Snake).Dance();
                }
            }
        }
        public static string FatHippo(Animal[] arrAnimal)
        {
            int fatmax = 0;
            string hename = "";
            foreach (Animal animal in arrAnimal)
            {
                if(animal is Hipo)
                {
                    if ((animal as Hipo).GetFatpercentage() > fatmax) 
                    {
                        fatmax = (animal as Hipo).GetFatpercentage();
                        hename = (animal as Hipo).GetName();
                    }
                }
            }
            return hename;
        }
       
    }
}
