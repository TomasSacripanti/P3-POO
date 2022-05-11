using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Persona
{
    public class Persona
    {
        protected string nombre;
        public Persona(string name)
        {
            nombre = name;
        }
        public override string ToString()
        {
            return $"Hola, mi nombre es {nombre}";
        }
    }
}
