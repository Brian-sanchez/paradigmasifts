using System;

namespace Unidad2_Ej12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int aprobado = 6;

            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;

            float promedio = 0;

            Console.WriteLine("Ingrese la primer nota del alumno");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese la segunda nota del alumno");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese la tercera nota del alumno");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese la cuarta nota del alumno");
            nota4 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine();

            if (promedio >= aprobado)
            {
                Console.WriteLine($"El alumno aprobo con un promedio de: {promedio}");
            } else
            {
                Console.WriteLine($"El alumno desaprobo con un promedio de: {promedio}");
            }
        }
    }
}
