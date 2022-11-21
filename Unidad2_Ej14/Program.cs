using System;

namespace Unidad2_Ej14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fecha = 0, fecha2 = 0, anyo = 0, anyo2 = 0, mes = 0, mes2 = 0, dia = 0, dia2 = 0;

            Console.WriteLine("Ingrese la primer fecha");
            fecha = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese la segunda fecha");
            fecha2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            anyo = fecha % 10000;
            anyo2 = fecha2 % 10000;

            if (anyo < anyo2)
            {
                Console.WriteLine($"{fecha} es la menor fecha");
            }
            else if (anyo > anyo2)
            {
                Console.WriteLine($"{fecha2} es la menor fecha");
            }
            else
            {
                mes = (fecha % 1000000) / 10000;
                mes2 = (fecha2 % 1000000) / 10000;
                if (mes < mes2)
                {
                    Console.WriteLine($"La fecha {fecha2} es la menor fecha");
                }
                else
                {
                    dia = fecha / 1000000;
                    dia2 = fecha2 / 1000000;
                    if (dia < dia2)
                    {
                        Console.WriteLine($"La fecha {fecha} es la menor fecha");
                    }
                    else if (dia > dia2)
                    {
                        Console.WriteLine($"La fecha {fecha2} es la menor fecha");
                    }
                    else
                    {
                        Console.WriteLine("Las fechas son iguales");
                    }
                }
            }
        }
    }
}