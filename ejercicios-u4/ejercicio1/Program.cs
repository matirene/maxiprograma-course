using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            */

            int n1, n2, resultado;

            resultado = 0;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2){
                resultado = n1 - n2;
            }
            
            if (n1 == n2){
                resultado = n1 + n2;
            }

            if (n1 < n2){
                resultado = n1 * n2;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
