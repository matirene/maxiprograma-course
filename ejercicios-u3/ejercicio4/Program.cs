using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 4
            Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            */
            
            int n1, n2, n3, n4;
            int menor;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                menor = n1;
            else
                menor = n2;

            if (n3 < menor)
                menor = n3;

            if (n4 < menor)
                menor = n4;

            Console.WriteLine("El menor de los numeros ingresados es: " + menor);
        }
    }
}
