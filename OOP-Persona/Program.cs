//Personas
//Crear un programa en C# que solicite al usuario tres nombres de personas y los almacene
//en un lista de objetos de tipo Persona. 
//Para ello, crear primero una clase Persona que tenga una propiedad Nombre de tipo string. 
//Además, la clase persona debe sobreescribir el método ToString() produciendo el siguiente
//resultado: "Hola! mi nombre es {Nombre}.".
//Finalizar el programa ejecutando el método ToString() para cada persona en la pantalla.


namespace OOP_Persona
{
    public class Program
    {
        public static void Main()
        {
            int cantidad = 3;
            List<Persona> list = new(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona número {i+1}: ");
                list.Add(new Persona(Console.ReadLine()));
            }
            foreach (Persona persona in list)
            {
                persona.ToString();
            }
        }
    }
}