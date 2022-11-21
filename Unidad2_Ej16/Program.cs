using System;

namespace Unidad2_Ej16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero = 0, numero2 = 0;

            Console.WriteLine("Ingrese el primer numero");
            numero = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numero > numero2)
            {
                Console.WriteLine($"Orden ascendente: {numero2}, {numero}");
            }
            else
            {
                Console.WriteLine($"Orden ascendente: {numero}, {numero2}");
            }
        }
    }
}