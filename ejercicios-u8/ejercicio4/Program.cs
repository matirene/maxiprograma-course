using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número 
            por valor y una variable por referencia. Que analice el número y escriba la variable recibida por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero. */

            int numero, resultado = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(numero, ref resultado);

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("El numero es positivo");
                    break;
                case -1:
                    Console.WriteLine("El numero es negativo");
                    break;
                case 0:
                    Console.WriteLine("El numero es 0");
                    break;
            }

        }

        static void positivoNegativoCero(int numero, ref int resultado){

            if(numero > 0)
                resultado = 1;

            if(numero < 0)
                resultado = -1;

            if(numero == 0)
                resultado = 0;
        }
    }
}
