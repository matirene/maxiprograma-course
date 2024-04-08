using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares. */

            int numero, maxP = 0, maxI = 0;

            bool banderaP = false, banderaI = false;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    if (!banderaP)
                    {
                        maxP = numero;
                        banderaP = true;
                    } else {
                        if (numero > maxP)
                        {
                            maxP = numero;
                        }
                    }
                } else {
                    if (!banderaI)
                    {
                        maxI = numero;
                        banderaI = true;   
                    } else {
                        if (numero > maxI)
                        {
                            maxI = numero;
                        }
                    }
                }
            }

            Console.WriteLine("El mayor de los numeros pares es " + maxP);
            Console.WriteLine("El mayor de los numeros impares es " + maxI);
        }
    }
}
