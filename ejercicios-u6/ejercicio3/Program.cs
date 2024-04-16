using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Hacer un programa para recibir listas de números positivos que están separadas entre
            sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista. */

            Console.WriteLine("Inicio del porgrama.");

            int n, count, numGrupo = 0;
            
            do
            {
                numGrupo++;
                count = 0;

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                while (n > 0) {

                    count++;

                    Console.WriteLine("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine()); 
                }

                if (count > 0)
                    Console.WriteLine("La cantidad de numeros de la lista " + numGrupo + " es: " + count);
                    
            } while (n >= 0);

            Console.WriteLine("Fin del programa.");
        }
    }
}
