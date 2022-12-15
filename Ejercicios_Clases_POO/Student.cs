using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clases_POO
{
    internal class Student : Person
    {
        public int id { get; set; }

        public Student(int id, int age, string name) : base(age, name)
        {
            this.id = id;
        }
        ~Student() { }
    }

}
