using System;

namespace Unidad2_Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroEntero = 5;
            int numeroEntero2 = 23;

            float porcentaje = (100 * numeroEntero) / numeroEntero2;

            Console.WriteLine($"Mis numeros enteros son: {numeroEntero} y {numeroEntero2}");
            Console.WriteLine();
            Console.WriteLine($"Y el pocertanje que representa el primer numero del segundo es: {porcentaje}%");
        }
    }
}