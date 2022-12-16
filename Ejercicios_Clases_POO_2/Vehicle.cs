using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clases_POO_2
{
    internal abstract class Vehicle
    {
        public int id { get; set; }
        public int wheels { get; set; }
        public int doors;

        public Vehicle(int id)
        {
            this.id = id;
        }

        public Vehicle(int id, int wheels)
        {
            this.id = id;
            this.wheels = wheels;
        }
        public Vehicle(int id, int wheels, int doors) 
        { 
            this.id = id;
            this.wheels = wheels;   
            this.doors = doors;
        }

        public abstract void GetSalute();
        
        ~Vehicle() { }
    }
}
