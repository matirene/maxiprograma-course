using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.*/

            int[] vNumeros = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vNumeros[x] = int.Parse(Console.ReadLine());
            }

            int acu = 0, promedio;

            for (int y = 0; y < 10; y++)
            {
                acu += vNumeros[y];
            }

            promedio = acu / 10;
            Console.WriteLine("El promedio es: " + promedio);

            for (int z = 0; z < 10; z++)
            {
                if (vNumeros[z] > promedio)
                    Console.WriteLine("Este numero es mayor al promedio: " + vNumeros[z]);                
            }
        }
    }
}
