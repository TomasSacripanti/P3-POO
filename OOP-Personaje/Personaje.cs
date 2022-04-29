using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Personaje
{
    abstract class Personaje
    {
        protected string nombre;
        protected int fuerza;
        protected int agilidad;
        protected int magia;
        public abstract int CalcularDanio();
        public abstract void Atacar();
    }
}
