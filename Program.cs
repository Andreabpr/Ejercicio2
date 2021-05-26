using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe una ciudad");
            String ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " bienvenido a " + ciudad);

            Console.ReadLine();
        }
    }
}
