using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clases_POO_2
{
    internal class Plane : Vehicle
    {
        public Plane(int id, int wheels, int doors) : base(id, wheels, doors)
        {
            this.id = id;
        }
        public override void GetSalute()
        {
            Console.WriteLine("Hello, I'm a Plane and my id is " + id + "and I have " + wheels + " wheels and " + doors + " doors.");
        }

        ~Plane() { }

    }
}
