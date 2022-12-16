using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clases_POO_2
{
    internal class Boat : Vehicle
    {
        public Boat(int id, int wheels, int doors) : base(id, wheels, doors)
        {
            this.id = id;
        }

        public override void GetSalute()
        {
            Console.WriteLine("Hello, I'm a Boat and my id is " + id + "and I have " + wheels + " wheels and " + doors + " doors.");

        }

        ~Boat() { }
    }
}
