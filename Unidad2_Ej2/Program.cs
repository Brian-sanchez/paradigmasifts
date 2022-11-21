using System;

namespace Unidad2_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int numero2 = 2;
            int numero3 = 3;
            int numero4 = 4;

            int suma = numero + numero2 + numero3 + numero4;

            Console.WriteLine($"Numeros declarados: {numero}, {numero2}, {numero3} y {numero4}");
            Console.WriteLine();
            Console.WriteLine($"La suma total sera de: {suma}");
        }
    }
}
