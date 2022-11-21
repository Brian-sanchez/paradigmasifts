using System;

namespace EjemploArraysUnidem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            string mensaje = "Presione 1 para Inicializar el vector por enumeración y mostrar su contenido:" +
                            "\nPresione 2 para inicialiar un vector de strings definidos por el usuario" +
                            "\nPresione 3 mejoramos el punto 2 con una mejor información al usuario" +
                            "\nPresione 4 Ejemplo de vectores Correlacionados EL PODER DEL INDICE" +
                            "\nPresione 5 Ejemplo de vectores pasado por referencias a metodos para cargar e imprimir1" +
                            "\nCualquier otra tecla para terminar";
            int opcion = 0;
            // declaro un vector pero no defino su tamaño
            do
            {
                Console.WriteLine(mensaje);
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        //declaro el vector
                        string[] semana;
                        // inicializo el vector
                        semana = new string[] { "Lunes", "Martes", "Miércoles", "jueves", "Viernes", "Sábado", "Domingo" };
                        // recorro el vector
                        for (int i = 0; i < semana.Length; i++)
                        {
                            Console.WriteLine($"El día de la semana en la posición {i} es {semana[i]}");
                        }
                        Console.WriteLine("\n\n");
                        // recorro el vector en forma inversa
                        for (int i = semana.Length - 1; i >= 0; i--)
                        {
                            Console.WriteLine($"El día de la semana en la posición {i} es {semana[i]}");
                        }
                        Console.WriteLine("\n\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Cuantos Datos Strings quiere almacenar?");
                        int cantidad = int.Parse(Console.ReadLine());
                        // declaro el vector
                        string[] datosDefinidosPorElUsuario = new string[cantidad];
                        // inicializo el vector
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write($"\nIngrese el dato para la posicion {i}: ");
                            datosDefinidosPorElUsuario[i] = Console.ReadLine();
                        }
                        for (int i = 0; i < datosDefinidosPorElUsuario.Length; i++) {
                            Console.WriteLine($"El dato en la posición {i} es {datosDefinidosPorElUsuario[i]}");
                        }
                        Console.WriteLine("\n\n");

                        break;
                }
            } while (opcion >= 1 && opcion <= 5);
        }
    }
}
