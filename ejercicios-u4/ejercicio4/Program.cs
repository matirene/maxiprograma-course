using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            si la suma de los dos primeros es mayor al producto del segundo con el tercero.*/

            int n1, n2, n3;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n3 = int.Parse(Console.ReadLine());

            int suma, producto;

            suma = n1 + n2;
            producto = n2 * n3;

            if (suma > producto)
            {
                Console.WriteLine("La suma es mayor al producto");
            } else {
                Console.WriteLine("La suma no es mayor al producto");
            }
            
        }
    }
}
