using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            Usar la función. */

            int precio, ventas;

            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida del articulo: ");
            ventas = int.Parse(Console.ReadLine());

            int monto = producto(precio, ventas);

            Console.WriteLine("El monto total a pagar es $" + monto);
        }

        static int producto(int n1, int n2){
            return n1 * n2;
        }

    }
}
