using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 0: Declarar dos  variables.
            int n1, n2, resultado;

            //Step 1: Pedir los valores.
            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            n2 = int.Parse(Console.ReadLine());

            //Step 2: Relizar el calculo.
            resultado = n1 + n2;

            //Step 3: Egresar el resultado.
            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
