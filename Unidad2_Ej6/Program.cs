using System;

namespace Unidad2_Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int triBase = 12;
            int triAltura = 5;

            float superficie = (triAltura * triBase) / 2;

            Console.WriteLine($"Base del triangulo es: {triBase}");
            Console.WriteLine();
            Console.WriteLine($"Altura del triangulo es: {triAltura}");
            Console.WriteLine();
            Console.WriteLine($"La superficie del triangulo es: {superficie}");
        }
    }
}
