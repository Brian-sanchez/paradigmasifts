using System;

namespace Unidad2_Ej11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantAutosVendidos = 0;
            float valorUnidad = 0;

            Console.WriteLine("Ingrese la cantidad de autos vendidos");
            cantAutosVendidos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese el valor por unidad");
            valorUnidad = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float salarioTotal = 5500 + (200 * cantAutosVendidos) + ((valorUnidad * cantAutosVendidos) * 5 / 100);

            Console.WriteLine($"El salario total es {salarioTotal}");
        }
    }
}