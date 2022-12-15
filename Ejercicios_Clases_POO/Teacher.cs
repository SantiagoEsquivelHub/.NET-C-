using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Clases_POO
{
    internal class Teacher : Person
    {
        public string subject { get; set; }
        public Teacher(string subject, int age, string name) : base(age, name)
        {
            this.subject = subject;
        }

        ~Teacher() { }
    }
}
