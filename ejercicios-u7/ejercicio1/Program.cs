using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.*/

            int[] vNumeros = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vNumeros[x] = int.Parse(Console.ReadLine());   
            }

            int maximo = vNumeros[0];
            int posicion = 1;

            for (int y = 0; y < 10; y++)
            {
                if (vNumeros[y] > maximo)
                {
                    maximo = vNumeros[y];
                    posicion = y + 1;
                }
            }

            Console.WriteLine("El maximo es: " + maximo);
            Console.WriteLine("La posicion es: " + posicion);


        }
    }
}
