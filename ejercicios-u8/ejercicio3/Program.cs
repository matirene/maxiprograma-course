using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo
            o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            Informar el promedio teniendo en cuenta sólo los números primos. */ 

            int numero;
            float acu = 0, count = 0, promedio;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if(primo(numero) == 1){
                    acu += numero;
                    count++;
                }

                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            promedio = acu / count;

            Console.WriteLine("El promedio de los numeros primos es: " + promedio);


        }

        static int primo(int numero){

            int count = 0;

            for (int x = 1; x <= numero; x++)
            {
                if (numero % x == 0)
                   count++;
            }

            if (count == 2)
                return 1;
            else 
                return 0;
        }
    }
}
