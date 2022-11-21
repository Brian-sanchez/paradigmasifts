using System;

namespace Unidad2_Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado = 5.5;

            double superficie = lado * lado;

            Console.WriteLine($"El lado del cuadrado es: {lado}");
            Console.WriteLine();
            Console.WriteLine($"La superficie del cuadrado es: {superficie}");
        }
    }
}