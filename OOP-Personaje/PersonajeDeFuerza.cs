using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Personaje
{
    internal class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string name, int agility, int magic)
        {
            nombre = name;
            fuerza = 100;
            agilidad = agility;
            magia = magic;
        }
        public override int CalcularDanio()
        {
            return fuerza * 2 + agilidad + magia;
        }
        public override void Atacar()
        {
            int x = CalcularDanio();
            Console.WriteLine($"{ nombre} hizo { x} de daño");
        }
    }
}
