using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Profesor
{
    public class Persona
    {
        protected int age;
        public void Saludar()
        {
            Console.WriteLine("Hola");
        }
        public void SetEdad(int edad)
        {
            age = edad;
        }
    }
}
