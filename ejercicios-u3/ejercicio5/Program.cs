using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 5 
            Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            */

            int a, b, c, d;
            int count = 0;

            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero:");
            d = int.Parse(Console.ReadLine());

            if(a > 100){
                Console.WriteLine("El primer valor " + a + " es mayor a 100");
                count++;
            }

            if(b > 100){
                Console.WriteLine("El segundo valor " + b + " es mayor a 100");
                count++;
            }

            if(c > 100){
                Console.WriteLine("El tercer valor " + c + " es mayor a 100");
                count++;
            }

            if(d > 100){
                Console.WriteLine("El cuarto valor " + d + " es mayor a 100");
                count++;
            }
            
            if(count == 0){
                Console.WriteLine("Ninguno es mayor a 100");
            }

            Console.WriteLine("Fin del programa");

        }
    }
}
