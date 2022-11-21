using System;

namespace Unidad2_Ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parcialNota = 0, tpNota = 0, integradorNota = 0, finalNota = 0;

            Console.WriteLine("Ingrese la nota del parcial");
            parcialNota = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese la nota del tp");
            tpNota = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese la nota del examen integrador");
            integradorNota = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"La nota final es {0.30 * parcialNota + 0.20 * tpNota + 0.50 * integradorNota}");
        }
    }
}