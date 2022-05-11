using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Profesor
{
    public class Estudiante : Persona
    {
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
        public void MostrarEdad()
        {
            Console.WriteLine($"Mi edad es {age}");
        }
    }
}
