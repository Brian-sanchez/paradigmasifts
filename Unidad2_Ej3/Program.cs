using System;

namespace Unidad2_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ancho = 12;
            int alto = 5;

            int superficie = alto * ancho;

            Console.WriteLine($"Ancho del rectangulo es: {ancho}");
            Console.WriteLine();
            Console.WriteLine($"Altura del rectangulo es: {alto}");
            Console.WriteLine();
            Console.WriteLine($"La superficie del rectangulo es: {superficie}");
        }
    }
}
