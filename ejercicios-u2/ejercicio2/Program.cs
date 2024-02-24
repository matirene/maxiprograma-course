using System;

namespace ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 2
            /* Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo. */
            
            // Step 0 - Crear 2 variables
            int num, resultado;

            // Step 1 - Pedir un numero
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            // Step 2 - Realizar la operacion
            resultado = num * num * num;

            // Step 3 - Mostrar el  resultado
            Console.WriteLine("El numero elevado al cubo es: " + resultado);
        }
    }
}
