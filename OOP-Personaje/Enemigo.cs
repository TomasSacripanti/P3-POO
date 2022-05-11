using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class Enemigo : IMoverse
    {
        protected string nombre;
        protected int vida;
        protected int nivel;
        public Enemigo(string name, int hp, int level)
        {
            nombre = name;
            vida = hp;
            nivel = level;
        }
        public void MoverseEjeX(int amount)
        {
            if (amount > 0) {
                Console.WriteLine($"{nombre} se movió {amount} veces a la derecha");
            } else if (amount < 0) {
                Console.WriteLine($"{nombre} se movió {Math.Abs(amount)} veces a la izquierda");
            } else {
                Console.WriteLine($"{nombre} no se movió");
            }
        }
        public void MoverseEjeY(int amount)
        {
            if (amount > 0) {
                Console.WriteLine($"{nombre} se movió {amount} veces para arriba");
            } else if (amount < 0) {
                Console.WriteLine($"{nombre} se movió {Math.Abs(amount)} veces para abajo");
            } else {
                Console.WriteLine($"{nombre} no se movió");
            }
        }
    }
}
