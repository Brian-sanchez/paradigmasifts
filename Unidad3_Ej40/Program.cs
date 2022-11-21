using System;
using System.Linq;

namespace Unidad3_Ej40
{
    internal class Program
    {
        static int cantInforme;
        static Informes[] informes;
        static void Main(string[] args)
        {
            string _codSucursal, _prodVendido;
            int _cantVendido;

            Console.WriteLine("Bienvenido, ingrese la cantidad de informes que va a llenar");
            
            cantInforme = int.Parse(Console.ReadLine());
            informes = new Informes[cantInforme];

            for (int i = 0; i < cantInforme; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Ingrese el código de la sucursal (alfabético 3 caracteres)");
                _codSucursal = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Ingrese el Producto vendido (alfabético 5 caracteres)");
                _prodVendido = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Ingrese la Cantidad vendida (numérico entero)");
                _cantVendido = int.Parse(Console.ReadLine());

                informes[i] = new Informes(_codSucursal, _prodVendido, _cantVendido);
            }

            Console.WriteLine();

            Console.WriteLine("Perfecto, dado a los datos que nos brindo ingrese el codigo de sucursal para saber la cantidad de vendidos que tuvo");
            _codSucursal = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < cantInforme; i++)
            {
                if (_codSucursal == informes[i].getCodSucursal())
                {
                    int cantVendido = informes[i].getCantVendido();
                    cantidadTotalVendida(_codSucursal, cantVendido);
                }
            }
            
            Console.WriteLine();

            Console.WriteLine("Dado a los datos que nos brindo se encontro la sucursal con mejor venta, por lo cual...");

            Console.WriteLine();

            sucursalConMejorVenta();
        }

        public static void cantidadTotalVendida(string cod_sucursal, int cant_vendido)
        {
            Console.WriteLine($"La sucursal {cod_sucursal} vendió {cant_vendido} productos");
        }

        public static void sucursalConMejorVenta()
        {
            int[] cantVentas = new int[cantInforme];
            int maxVenta;
            string sucursal = "";

            for (int i = 0; i < cantInforme; i++)
            {
                cantVentas[i] = informes[i].getCantVendido();
            }

            maxVenta = cantVentas.Max();

            for (int i = 0; i < cantInforme; i++)
            {
                if (maxVenta == informes[i].getCantVendido())
                {
                    sucursal = informes[i].getCodSucursal();
                }
            }

            Console.WriteLine($"La sucursal con mejor venta fue {sucursal} y vendió {maxVenta} productos");
        }
    }
}