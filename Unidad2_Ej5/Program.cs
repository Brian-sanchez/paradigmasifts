using System;

namespace Unidad2_Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al calculador de segundos, por favor ingrese un numero entero como horas, minutos y segundos");
            Console.WriteLine();
            Console.WriteLine("Ingrese un numero para Horas");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese un numero para Minutos");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese un numero para Segundos");
            int segundos = int.Parse(Console.ReadLine());

            int horasEnSeg = horas * 3600;
            int minutosEnSeg = minutos * 60;

            int SegundosTotales = horasEnSeg + minutosEnSeg + segundos;

            Console.WriteLine();
            Console.WriteLine($"La cantidad de segundos son: {SegundosTotales}s");
        }
    }
}
