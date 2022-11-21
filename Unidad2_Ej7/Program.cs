using System;

namespace Unidad2_Ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroReal = 1;
            int numeroReal2 = 2;
            int numeroReal3 = 3;
            int numeroReal4 = 4;
            int numeroReal5 = 5;
            int numeroReal6 = 6;

            int promedio = (numeroReal + numeroReal2 + numeroReal3 + numeroReal4 + numeroReal5 + numeroReal6) / 6;

            Console.WriteLine($"Mis numeros reales son: {numeroReal}, {numeroReal2}, {numeroReal3}, {numeroReal4}, {numeroReal5}, {numeroReal6}");
            Console.WriteLine();
            Console.WriteLine($"Y el promedio de la suma total es: {promedio}");
        }
    }
}