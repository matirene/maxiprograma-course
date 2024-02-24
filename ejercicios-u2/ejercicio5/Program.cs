using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 5
            /* Hacer un programa para ingresar por teclado las tres notas de exámenes 
            de un alumno y luego calcule y emita por pantalla el promedio final. */

            // Crear las variables.
            float n1, n2, n3, promedio;

            // Pedir las notas
            Console.WriteLine("Ingrese la primera nota");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota");
            n3 = float.Parse(Console.ReadLine());


            // Calcular el promedio.
            promedio = (n1 + n2 + n3) / 3;

            // Mostrar el resultado.
            Console.WriteLine("El promedio final es: " + promedio.ToString("0.0"));
        }
    }
}
