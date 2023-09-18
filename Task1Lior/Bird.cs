using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lior
{
    internal class Bird: Animal,IBird
    {
        protected int flightaltitude;
        protected int wingspanlength;
        public Bird(string name, int age, bool isApexPredator, int caloris, int flightaltitude, int wingspanlength) :
                base(name, age, isApexPredator, caloris)
        {
            this.flightaltitude = flightaltitude;
            this.wingspanlength = wingspanlength;
        }
        public int GetFlightaltitude()
        {
            return flightaltitude; 
        }
        public int GetWingspanlength()
        {
            return wingspanlength;
        }
        public void SetFlightaltitude(int flightaltitude)
        {
            this.flightaltitude = flightaltitude;
        }
        public void SetWingspanlength(int wingspanlength)
        {
            this.wingspanlength = wingspanlength;
        }
        public override string ToString()
        {
            return $"flightaltitude:{flightaltitude}\nwingspanlength{wingspanlength}";
        }
        public string Sing()
        {
            return "🎶🎶🎶🎶🎶🎶🎶🎶🎶🎶🎶🎶";
        }
        public string Dance()
        {
            return "👯‍♀️👯👯‍♂️⛹️🏋️‍♂️";
        }

        public void Amra()
        {
            Console.WriteLine("Mamri");
        }

        public void Nxita()
        {
            Console.WriteLine("Noxet"); 
        }

        public void Dia()
        {
            Console.WriteLine("Dia"); ;
        }
    }
}
