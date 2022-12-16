using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clases_POO_3
{
    internal class Animal
    {
        public string type { get; set; }
        public string hairColor { get; set; }
        public bool isDomestic { get; set; }
        public int paws { get; set; }

        public Animal(string type, string hairColor, bool isDomestic, int paws)
        {
            this.type = type;   
            this.hairColor = hairColor;
            this.isDomestic= isDomestic;
            this.paws = paws;
        }

        ~Animal() { }
    }
}
