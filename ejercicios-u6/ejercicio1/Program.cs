using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos. */

            int n;
            int count, countPrimos = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                count = 0; //Contador Divisores.

                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                        count++;
                }

                if(count == 2)
                    countPrimos++;
            }

            Console.WriteLine("La cantidad de numeros primos es: " + countPrimos);
        }
    }
}
