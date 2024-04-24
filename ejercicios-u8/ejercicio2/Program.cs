using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.*/

            int numero, count = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (par(numero) == 1)
                    count++;
                
            }

            Console.WriteLine("La cantidad de numeros pares son " + count);


        }

        static int par(int numero){
            if (numero % 2 == 0)
                return 1;
            else
                return 0;
        }
    }
}
