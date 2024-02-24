using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 3
            /* Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
            y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado
            que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados. */
            
            // Step 0 - Crear 3 variales.
            float km, velocidad, tiempo;

            // Step 1 - Pedir los km y velocidad.
            Console.WriteLine("Ingrese los km entre las ciudades");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio del vehiculo");
            velocidad = float.Parse(Console.ReadLine());

            // Step 2 - Calcular el tiempo aprox.
            tiempo = km / velocidad;

            // Step 3 - Mostrar el resultado.
            Console.WriteLine("El tiempo aproximado es: " + tiempo.ToString("0.00") + " horas");
        }
    }
}
