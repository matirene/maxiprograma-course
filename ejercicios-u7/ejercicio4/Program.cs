using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
                - Número de Artículo (1 a 15)
                - Cantidad Vendida 

                Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
                Se pide determinar e informar:
                a) El número de artículo que más se vendió en total.
                b) Los números de artículos que no registraron ventas.
                c) Cuantas unidades se vendieron del número de artículo 10. */

                int[] vCantVendida = new int [15];

                int articulo, cantVendida;

                Console.WriteLine ("Ingrese el numero de articulo: ");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine ("Ingrese la cantidad vendida: ");
                cantVendida = int.Parse(Console.ReadLine());

                while (articulo != 0)
                {
                    vCantVendida[articulo - 1] += cantVendida;

                    Console.WriteLine ("Ingrese el numero de articulo: ");
                    articulo = int.Parse(Console.ReadLine());
                    Console.WriteLine ("Ingrese la cantidad vendida: ");
                    cantVendida = int.Parse(Console.ReadLine());
                }


                // VENTAS DE TODOS LOS ARTICULOS
                for (int x = 0; x < 15; x++)
                {
                    Console.WriteLine ("La cantidad vendida en el articulo " + (x + 1) + " es: " + vCantVendida[x]);
                    Console.WriteLine ("------------------------------------------------------");
                }

                // a) ARTICULO CON MAS VENTAS
                int maxVentas = vCantVendida[0];
                int artMaxVentas = 1;

                for (int y = 0; y < 15; y++)
                {
                    if (vCantVendida[y] > maxVentas)
                    {
                        maxVentas = vCantVendida[y];
                        artMaxVentas = y + 1;
                    }
                }

                Console.WriteLine("- El articulo con mas ventas es el " + artMaxVentas + " con " + maxVentas + " articulos vendidos.");

                // b) ARTICULOS SIN VENTAS
                for (int z = 0; z < 15; z++)
                {
                    if (vCantVendida[z] == 0)
                    {
                        Console.WriteLine("- El articulo " + (z + 1) + " no registro ventas.");
                    }
                }
                
                // c) VENTAS DEL ARTICULO 10
                Console.WriteLine("- La cantidad de ventas del articulo 10 es de " + vCantVendida[9] + " articulos.");

        }
    }
}
