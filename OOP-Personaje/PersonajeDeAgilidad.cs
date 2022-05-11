using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string name, int strength, int agility, int magic)
        {
            nombre = name;
            fuerza = strength;
            agilidad = agility;
            magia = magic;
        }
        public override int CalcularDanio()
        {
            return (fuerza / 2) * agilidad * (magia / 2);
        }
        public override void Atacar()
        {
            int x = CalcularDanio();
            Console.WriteLine($"{ nombre} hizo {x} de daño");
        }
    }
}